using System.Data.SqlTypes;
using Quiz.Domain.Entity;
using Quiz.Domain.Repository;
using Quiz.Infra.Context;
using Dapper;

namespace Quiz.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<User> Login(string email, string password)
        {
            try
            {
                string sql = @"SELECT
                                    use.name,
                                    use.email
                                FROM
                                    tb_user use
                                WHERE
                                    use.email = @email
                                    AND use.password = @password";

                var parms = new {
                    email, password
                };

                return await _context._connection.QueryFirstOrDefaultAsync<User>(sql, parms);
            }
            catch (Exception ex)
            {
                throw new SqlTypeException(ex.Message);
            }
            finally
            {
                _context.DisposeAsync();
            }
        }

        public async Task Insert(User user)
        {
            try
            {
                string sql = @"INSERT 
                                INTO
                                    tb_user
                                    (
                                        name,
                                        email,
                                        password,
                                        phone,
                                        date_birth,
                                        token
                                    ) VALUES
                                    (
                                        @name,
                                        @email,
                                        @password,
                                        @phone,
                                        @date_birth,
                                        @token
                                    )";

                var parms = new {
                    name = user.Name,
                    email = user.Email,
                    password = (string)user.Password!,
                    phone = user.Phone,
                    date_birth = user.Date_birth,
                    token = user.Token
                };

                await _context._connection.ExecuteAsync(sql, parms);
            }
            catch (Exception ex)
            {
                throw new SqlTypeException(ex.Message);
            }
            finally
            {
                _context.DisposeAsync();
            }
        }
    }
}