using Ungerboeck.Api.Models;
using Ungerboeck.Api.Models.Subjects;
using System.Collections.Generic;
using Ungerboeck.Api.Models.Options;
using System.Net.Http;
using System;

namespace Ungerboeck.Api.Sdk.Endpoints
{
  /// <summary>
  /// Find endpoint calls for this subject here.
  /// </summary>
  public class AlternateAddresses : Base<AlternateAddressesModel>
  {
    protected internal AlternateAddresses(ApiClient api) : base(api) { }

    /// <summary>
    /// Use this endpoint to search for a list of this subject.
    /// </summary>
    /// <param name="searchMetadata">After searching, this will contain search info, such as ResultsTotal.  If your search resulted in more than one page, this will also be filled with API links to navigate pages.</param>
    /// <param name="orgCode">Fill this with the Organization Code in which the search will take place.</param>
    /// <param name="searchOData">Fill this with OData to query for what you are looking for.  We highly suggest reading our 'Search Using the API' knowledge base article or Ungerboeck API Github examples to learn how to do this. </param>
    /// <param name="options">This contains optional configurations used for searching.</param>
    /// <returns>A list of this subject's model.</returns>
    public new Ungerboeck.Api.Models.Search.SearchResponse<AlternateAddressesModel> Search(string orgCode, string searchOData, Search options = null)
    {
      return base.Search(orgCode, searchOData, options);
    }

    /// <summary>
    /// Use this endpoint to get a single entry of this subject with parameters.
    /// </summary>
    /// <param name="options">This contains optional configurations.</param>
    /// <returns>A single model for this subject.</returns>
    [Obsolete("RecordType as a URL parameter is no longer used.  Use Get() without RecordType parameter")]
    public AlternateAddressesModel Get(string orgCode, string account, int sequenceNumber, string recordType, Ungerboeck.Api.Models.Options.Subjects.AlternateAddresses options = null)
    {
      return base.Get(new { orgCode, account, sequenceNumber, recordType }, options);
    }

    /// <summary>
    /// Use this endpoint to get a single entry of this subject with parameters.
    /// </summary>
    /// <param name="options">This contains optional configurations.</param>
    /// <returns>A single model for this subject.</returns>    
    public AlternateAddressesModel Get(string orgCode, string account, int sequenceNumber, Ungerboeck.Api.Models.Options.Subjects.AlternateAddresses options = null)
    {
      return base.Get(new { orgCode, account, sequenceNumber }, options);
    }

    /// <summary>
    /// Use this endpoint to edit a single entry of this subject.
    /// </summary>
    /// <param name="model">This should contain a filled model of this subject.  Note that any null model properties will be ignored for the save.</param>
    /// <param name="options">This contains optional configurations.</param>
    /// <returns>An updated, single model for this subject.</returns>
    public AlternateAddressesModel Update(AlternateAddressesModel model, Ungerboeck.Api.Models.Options.Subjects.AlternateAddresses options = null)
    {
      return base.Update(new { model.OrganizationCode, model.Account, model.SequenceNumber }, model, options);
    }

    /// <summary>
    /// Use this endpoint to add a single entry of this subject.
    /// </summary>
    /// <param name="model">This should contain a filled model of this subject.  Note that any null model properties will be ignored for the save.</param>
    /// <param name="options">This contains optional configurations.</param>
    /// <returns>A newly added, single model for this subject.</returns>
    public AlternateAddressesModel Add(AlternateAddressesModel model, Ungerboeck.Api.Models.Options.Subjects.AlternateAddresses options = null)
    {
      return base.Add(model, options);
    }

    /// <summary>
    /// Use this endpoint to delete a single entry of this subject.
    /// </summary>
    /// <param name="options">This contains optional configurations.</param>
    /// <returns>Nothing if successful.</returns>
    public HttpResponseMessage Delete(string orgCode, string accountCode, int sequenceNumber, Ungerboeck.Api.Models.Options.Subjects.AlternateAddresses options = null)
    {
      return base.Delete(new { orgCode, accountCode, sequenceNumber }, options);
    }

    protected override void CollectValidationOverridesFromOptions(ref List<int> validationOverrides, Dictionary<string, string> headers, Ungerboeck.Api.Models.Options.Base baseOptions)
    {
      var options = GetOptions<Models.Options.Subjects.AlternateAddresses>(baseOptions);
      SetValidation(validationOverrides, options?.KeepLabelsUnsynchronized, ValidationCodes.KeepLabelsUnsynchronized);
    }
  }
}
