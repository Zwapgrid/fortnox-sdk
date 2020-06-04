using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IArticleFileConnectionConnector : IEntityConnector<Sort.By.ArticleFileConnection?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ArticleNumber { get; set; }

        /// <summary>
        /// Get a article file connection based on fileId
        /// </summary>
        /// <param name="fileId">The id of the file to get</param>
        /// <returns>The found article file connection</returns>
        ArticleFileConnection Get(string fileId);

        /// <summary>
        /// Creates a new connection between a file and an article
        /// </summary>
        /// <param name="articleFileConnection">The article file connection to create</param>
        /// <returns>The created article file connection</returns>
        ArticleFileConnection Create(ArticleFileConnection articleFileConnection);

        /// <summary>
        /// Deletes a connected file from a article
        /// </summary>
        /// <param name="fileId">The id of the file to delete</param>
        void Delete(string fileId);

        /// <summary>
        /// Gets a list of article file Connections
        /// </summary>
        /// <returns></returns>
        EntityCollection<ArticleFileConnectionSubset> Find();
    }

    /// <remarks/>
    public class ArticleFileConnectionConnector : EntityConnector<ArticleFileConnection, EntityCollection<ArticleFileConnectionSubset>, Sort.By.ArticleFileConnection?>, IArticleFileConnectionConnector
	{
		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string ArticleNumber { get; set; }

		/// <remarks/>
		public ArticleFileConnectionConnector()
		{
			Resource = "articlefileconnections";
		}

		/// <summary>
		/// Get a article file connection based on fileId
		/// </summary>
		/// <param name="fileId">The id of the file to get</param>
		/// <returns>The found article file connection</returns>
		public ArticleFileConnection Get(string fileId)
		{
			return BaseGet(fileId);
		}

		/// <summary>
		/// Creates a new connection between a file and an article
		/// </summary>
		/// <param name="articleFileConnection">The article file connection to create</param>
		/// <returns>The created article file connection</returns>
		public ArticleFileConnection Create(ArticleFileConnection articleFileConnection)
		{
			return BaseCreate(articleFileConnection);
		}

		/// <summary>
		/// Deletes a connected file from a article
		/// </summary>
		/// <param name="fileId">The id of the file to delete</param>
		public void Delete(string fileId)
		{
			BaseDelete(fileId);
		}


		/// <summary>
		/// Gets a list of article file Connections
		/// </summary>
		/// <returns></returns>
		public EntityCollection<ArticleFileConnectionSubset> Find()
		{
			return BaseFind();
		}
	}
}
