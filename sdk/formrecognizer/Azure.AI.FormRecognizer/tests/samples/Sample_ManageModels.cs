﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.DocumentAnalysis.Tests;
using Azure.Core.TestFramework;

namespace Azure.AI.FormRecognizer.DocumentAnalysis.Samples
{
    public partial class DocumentAnalysisSamples : SamplesBase<DocumentAnalysisTestEnvironment>
    {
        [RecordedTest]
        public void ManageModels()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            #region Snippet:FormRecognizerSampleManageModels

            var client = new DocumentModelAdministrationClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            // Check number of custom models in the FormRecognizer account, and the maximum number of models that can be stored.
            ResourceDetails resourceDetails = client.GetResourceDetails();
            Console.WriteLine($"Resource has {resourceDetails.DocumentModelCount} models.");
            Console.WriteLine($"It can have at most {resourceDetails.DocumentModelLimit} models.");

            // List the first ten or fewer models currently stored in the account.
            Pageable<DocumentModelSummary> models = client.GetModels();

            foreach (DocumentModelSummary modelSummary in models.Take(10))
            {
                Console.WriteLine($"Custom Model Summary:");
                Console.WriteLine($"  Model Id: {modelSummary.ModelId}");
                if (string.IsNullOrEmpty(modelSummary.Description))
                    Console.WriteLine($"  Model description: {modelSummary.Description}");
                Console.WriteLine($"  Created on: {modelSummary.CreatedOn}");
            }

            // Create a new model to store in the account

#if SNIPPET
            Uri blobContainerUri = new Uri("<blobContainerUri>");
#else
            Uri blobContainerUri = new Uri(TestEnvironment.BlobContainerSasUrl);
#endif
            BuildModelOperation operation = client.BuildModel(WaitUntil.Completed, blobContainerUri, DocumentBuildMode.Template);
            DocumentModelDetails model = operation.Value;

            // Get the model that was just created
            DocumentModelDetails newCreatedModel = client.GetModel(model.ModelId);

            Console.WriteLine($"Custom Model with Id {newCreatedModel.ModelId} has the following information:");

            Console.WriteLine($"  Model Id: {newCreatedModel.ModelId}");
            if (string.IsNullOrEmpty(newCreatedModel.Description))
                Console.WriteLine($"  Model description: {newCreatedModel.Description}");
            Console.WriteLine($"  Created on: {newCreatedModel.CreatedOn}");

            // Delete the created model from the account.
            client.DeleteModel(newCreatedModel.ModelId);

            #endregion
        }
    }
}
