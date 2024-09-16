namespace TodoListService.Infrastructure
{
    /// <summary>
    /// Contains a list of all the Entra ID app roles this app depends on and works with.
    /// </summary>
    public static class AppRole
    {
        /// <summary>
        /// User readers can read basic profiles of all users in the directory.
        /// </summary>
        public const string ReadModify = "ToDoList.ReadModify";

        /// <summary>
        /// Directory viewers can view objects in the whole directory.
        /// </summary>
        public const string Delete = "ToDoList.Delete";
    }

    /// <summary>
    /// Wrapper class the contain all the authorization policies available in this application.
    /// </summary>
    public static class AuthorizationPolicies
    {
        public const string AssignmentToReadModifyRequired = "AssignmentToReadModifyRequired";
        public const string AssignmentToDeleteRequired = "AssignmentToDeleteRequired";
    }
}
