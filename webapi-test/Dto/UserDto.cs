namespace webapi_test.Dto
{
    public class UserDto: BaseDto<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone {get; set;}
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
    }
}