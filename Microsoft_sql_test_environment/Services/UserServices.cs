using Microsoft_sql_test_environment.Entities;
using Microsoft_sql_test_environment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_sql_test_environment.Services
{
    public class UserServices
    {
        UserRepository userRepository = new UserRepository();

        public List<User> addUsers(List<User> users)
        {
            return userRepository.addUsers(users);
        }
        public async Task<List<User>> GetTop10000FromUsers()
        {
            return await userRepository.GetTop10000FromUsers();
        }
        public async Task<List<User>> GetSetRowCount50000FromUsers()
        {
            return await userRepository.GetSetRowCount50000FromUsers();
        }
        public async Task<List<int>> GetDivisionResultFromUsers()
        {
            return await userRepository.GetDivisionResultFromUsers();
        }
        public async Task<List<string>> GetConcatenationResultFromUsers()
        {
            return await userRepository.GetConcatenationResultFromUsers();
        }
        public async Task<List<User>> GetExceptFromUsers()
        {
            return await userRepository.GetExceptFromUsers();
        }
        public async Task<List<User>> GetReplaceFromUsers()
        {
            return await userRepository.GetReplaceFromUsers();
        }
    }
}
