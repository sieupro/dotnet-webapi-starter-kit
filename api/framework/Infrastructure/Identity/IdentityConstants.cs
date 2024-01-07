﻿using System.Collections.ObjectModel;

namespace FSH.Framework.Infrastructure.Identity;
internal static class IdentityConstants
{
    public const int PasswordLength = 6;
    public const string SchemaName = "identity";
    public const string RootTenant = "root";
    public const string DefaultPassword = "123Pa$$word!";

    public static class Roles
    {
        public const string Admin = nameof(Admin);
        public const string Basic = nameof(Basic);
        public static IReadOnlyList<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
        {
            Admin,
            Basic
        });
    }

    public static class Permissions
    {
        public const string Basic = nameof(Basic);
    }
    public static class Claims
    {
        public const string Permission = "permission";
    }
}
