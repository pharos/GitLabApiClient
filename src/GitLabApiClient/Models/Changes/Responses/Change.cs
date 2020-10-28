using Newtonsoft.Json;

namespace GitLabApiClient.Models.Changes.Responses
{
    public sealed class Change
    {
        [JsonProperty("old_path")]
        public string OldPath;

        [JsonProperty("new_path")]
        public string NewPath;

        [JsonProperty("a_mode")]
        public string AMode;

        [JsonProperty("b_mode")]
        public string BMode;

        [JsonProperty("diff")]
        public string Diff;

        [JsonProperty("new_file")]
        public bool IsNew;

        [JsonProperty("renamed_file")]
        public bool IsRenamed;

        [JsonProperty("deleted_file")]
        public bool IsDeleted;
    }
}
