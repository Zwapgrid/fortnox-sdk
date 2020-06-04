using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IProjectConnector : IEntityConnector<Sort.By.Project?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ProjectLeader { get; set; }

        /// <summary>
        /// Gets a project based on project number
        /// </summary>
        /// <param name="projectNumber">The project number to find</param>
        /// <returns>The found project</returns>
        Project Get(string projectNumber);

        /// <summary>
        /// Updates a project
        /// </summary>
        /// <param name="project">The project to update</param>
        /// <returns>The updated project</returns>
        Project Update(Project project);

        /// <summary>
        /// Creates a new project
        /// </summary>
        /// <param name="project"> The project to Create</param>
        /// <returns>The created project</returns>
        Project Create(Project project);

        /// <summary>
        /// Deletes a project
        /// </summary>
        /// <param name="projectNumber">The project number of the project to delete</param>
        /// <returns>If the project was deleted or not</returns>
        void Delete(string projectNumber);

        /// <summary>
        /// Gets at list of project, use the properties of ProjectConnector to limit the search
        /// </summary>
        /// <returns>A list of projects</returns>
        EntityCollection<ProjectSubset> Find();
    }

    /// <remarks/>
    public class ProjectConnector : EntityConnector<Project, EntityCollection<ProjectSubset>, Sort.By.Project?>, IProjectConnector
	{
        /// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string Description { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string ProjectLeader { get; set; }

		/// <remarks/>
		public ProjectConnector()
		{
			Resource = "projects";
		}

		/// <summary>
		/// Gets a project based on project number
		/// </summary>
		/// <param name="projectNumber">The project number to find</param>
		/// <returns>The found project</returns>
		public Project Get(string projectNumber)
		{
			return BaseGet(projectNumber);
		}

		/// <summary>
		/// Updates a project
		/// </summary>
		/// <param name="project">The project to update</param>
		/// <returns>The updated project</returns>
		public Project Update(Project project)
		{
			return BaseUpdate(project, project.ProjectNumber);
		}

		/// <summary>
		/// Creates a new project
		/// </summary>
		/// <param name="project"> The project to Create</param>
		/// <returns>The created project</returns>
		public Project Create(Project project)
		{
			return BaseCreate(project);
		}

		/// <summary>
		/// Deletes a project
		/// </summary>
		/// <param name="projectNumber">The project number of the project to delete</param>
		/// <returns>If the project was deleted or not</returns>
		public void Delete(string projectNumber)
		{
			BaseDelete(projectNumber);
		}

		/// <summary>
		/// Gets at list of project, use the properties of ProjectConnector to limit the search
		/// </summary>
		/// <returns>A list of projects</returns>
		public EntityCollection<ProjectSubset> Find()
		{
			return BaseFind();
		}
	}
}
