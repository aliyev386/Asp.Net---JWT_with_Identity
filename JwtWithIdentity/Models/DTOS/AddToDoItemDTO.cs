namespace JwtWithIdentity.Models.DTOS
{
    public class AddToDoItemDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;


        public string UserId { get; set; }
    }
}
