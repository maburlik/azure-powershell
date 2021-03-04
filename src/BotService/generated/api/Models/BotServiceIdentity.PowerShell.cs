// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(BotServiceIdentityTypeConverter))]
    public partial class BotServiceIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.BotServiceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BotServiceIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ChannelName = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName?) content.GetValueForProperty("ChannelName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ChannelName, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ConnectionName = (string) content.GetValueForProperty("ConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ConnectionName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.BotServiceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BotServiceIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ChannelName = (Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName?) content.GetValueForProperty("ChannelName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ChannelName, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ConnectionName = (string) content.GetValueForProperty("ConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).ConnectionName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.BotServiceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BotServiceIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.BotServiceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BotServiceIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BotServiceIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotServiceIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(BotServiceIdentityTypeConverter))]
    public partial interface IBotServiceIdentity

    {

    }
}