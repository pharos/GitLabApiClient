﻿using GitLabApiClient.Models.Merges;

namespace GitLabApiClient
{
    internal sealed class ProjectMergeRequestsQueryBuilder : MergeRequestsQueryBuilder
    {
        protected override void BuildCore(MergeRequestsQueryOptions options)
        {
            if (!(options is ProjectMergeRequestsQueryOptions projectOptions))
            {
                base.BuildCore(options);
                return;
            }

            Add("id", projectOptions.ProjectId);
            Add(projectOptions.MergeRequestsIds);
            base.BuildCore(options);
        }
    }
}
