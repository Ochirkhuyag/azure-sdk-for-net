// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Action to be applied.
    /// Please note <see cref="AlertProcessingRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AddActionGroups"/> and <see cref="RemoveAllActionGroups"/>.
    /// </summary>
    public abstract partial class AlertProcessingRuleAction
    {
        /// <summary> Initializes a new instance of AlertProcessingRuleAction. </summary>
        protected AlertProcessingRuleAction()
        {
        }

        /// <summary> Initializes a new instance of AlertProcessingRuleAction. </summary>
        /// <param name="actionType"> Action that should be applied. </param>
        internal AlertProcessingRuleAction(AlertProcessingRuleActionType actionType)
        {
            ActionType = actionType;
        }

        /// <summary> Action that should be applied. </summary>
        internal AlertProcessingRuleActionType ActionType { get; set; }
    }
}
