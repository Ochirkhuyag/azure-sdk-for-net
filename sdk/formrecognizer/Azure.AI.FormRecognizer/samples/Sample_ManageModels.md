# Manage models

This sample demonstrates how to manage the models stored in your account.

To get started you'll need a Cognitive Services resource or a Form Recognizer resource.  See [README][README] for prerequisites and instructions.

## Creating a `DocumentModelAdministrationClient`

To create a new `DocumentModelAdministrationClient` you need the endpoint and credentials from your resource. In the sample below you'll use a Form Recognizer API key credential by creating an `AzureKeyCredential` object, that if needed, will allow you to update the API key without creating a new client.

You can set `endpoint` and `apiKey` based on an environment variable, a configuration setting, or any way that works for your application.

```C# Snippet:CreateDocumentModelAdministrationClient
string endpoint = "<endpoint>";
string apiKey = "<apiKey>";
var credential = new AzureKeyCredential(apiKey);
var client = new DocumentModelAdministrationClient(new Uri(endpoint), credential);
```

## Operations

Operations related to models that can be executed are:
- Check the number of custom models in the FormRecognizer resource account, and the maximum number of custom models that can be stored there.
- List the models currently stored in the resource account.
- Get a specific model using the model's Id.
- Delete a custom model from the resource account.

## Manage Models Asynchronously

```C# Snippet:FormRecognizerSampleManageModelsAsync
var client = new DocumentModelAdministrationClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

// Check number of custom models in the FormRecognizer account, and the maximum number of models that can be stored.
ResourceDetails resourceDetails = await client.GetResourceDetailsAsync();
Console.WriteLine($"Resource has {resourceDetails.DocumentModelCount} models.");
Console.WriteLine($"It can have at most {resourceDetails.DocumentModelLimit} models.");

// List the first ten or fewer models currently stored in the account.
AsyncPageable<DocumentModelSummary> models = client.GetModelsAsync();

int count = 0;
await foreach (DocumentModelSummary modelSummary in models)
{
    Console.WriteLine($"Custom Model Summary:");
    Console.WriteLine($"  Model Id: {modelSummary.ModelId}");
    if (string.IsNullOrEmpty(modelSummary.Description))
        Console.WriteLine($"  Model description: {modelSummary.Description}");
    Console.WriteLine($"  Created on: {modelSummary.CreatedOn}");
    if (++count == 10)
        break;
}

// Create a new model to store in the account
Uri blobContainerUri = new Uri("<blobContainerUri>");
BuildModelOperation operation = await client.BuildModelAsync(WaitUntil.Completed, blobContainerUri, DocumentBuildMode.Template);
DocumentModelDetails model = operation.Value;

// Get the model that was just created
DocumentModelDetails newCreatedModel = await client.GetModelAsync(model.ModelId);

Console.WriteLine($"Custom Model with Id {newCreatedModel.ModelId} has the following information:");

Console.WriteLine($"  Model Id: {newCreatedModel.ModelId}");
if (string.IsNullOrEmpty(newCreatedModel.Description))
    Console.WriteLine($"  Model description: {newCreatedModel.Description}");
Console.WriteLine($"  Created on: {newCreatedModel.CreatedOn}");

// Delete the model from the account.
await client.DeleteModelAsync(newCreatedModel.ModelId);
```

## Manage Models Synchronously

```C# Snippet:FormRecognizerSampleManageModels
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

Uri blobContainerUri = new Uri("<blobContainerUri>");
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
```

To see the full example source files, see:
* [Manage models (Asynchronous)](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/formrecognizer/Azure.AI.FormRecognizer/tests/samples/Sample_ManageModelsAsync.cs)
* [Manage models (Synchronous)](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/formrecognizer/Azure.AI.FormRecognizer/tests/samples/Sample_ManageModels.cs)

[README]: https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/formrecognizer/Azure.AI.FormRecognizer#getting-started