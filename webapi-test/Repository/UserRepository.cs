using webapi_test.Repository.Contract;
using webapi_test.Dto;

namespace webapi_test.Repository
{
    public class UserRepository:BaseRepository<UserDto, Guid>, IUserRepository
    {
        public UserRepository() {
            // Init data
            Entities.Add(new UserDto {Id = new Guid("b95d05b4-a302-4f20-8b56-f8c1f4bfbd26"), Name = "Richard Blues", 
                Email = "r.blues@test.com", Phone= "022321233", Address = "Ayani Street 23",
                AvatarUrl = "https://pickaface.net/gallery/avatar/unr_random_180410_1905_z1exb.png" });
            Entities.Add(new UserDto {Id = new Guid("41ef7c00-4275-4d40-992c-61578f05dffd"), Name = "Michael Bolton", 
                Email = "m.bolton@test.com", Phone= "0361564733", Address = "Schrodinger Avenue 122",
                AvatarUrl= "https://pickaface.net/gallery/avatar/Horrida55881a21f418f.png" });
            Entities.Add(new UserDto {Id = new Guid("1de162db-6d08-4bf0-810d-b3f5f0b6d19a"), Name = "John Henry", 
                Email = "john.henry@test.com", Phone= "0361562223", Address = "Beverly Hills 90210" });
        }
    }
}