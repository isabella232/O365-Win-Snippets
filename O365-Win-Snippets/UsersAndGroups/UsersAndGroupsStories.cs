﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O365_Win_Snippets
{
    class UsersAndGroupsStories
    {
        public static async Task<bool> TryGetAadGraphClientAsync()
        {
            var client = await UsersAndGroupsSnippets.GetGraphClientAsync();
            return client != null;
        }

        public static async Task<bool> TryGetUsersAsync()
        {
            var users = await UsersAndGroupsSnippets.GetUsersAsync();

            return users != null;
        }

        public static async Task<bool> TryGetTenantAsync()
        {
            var details = await UsersAndGroupsSnippets.GetTenantDetailsAsync();

            return details != null;
        }

        public static async Task<bool> TryGetGroupsAsync()
        {
            var groups = await UsersAndGroupsSnippets.GetGroupsAsync();

            return groups != null;
        }

    }
}
