namespace Application.Common.Models
{
    public class PaginationInput
    {
        public int currentPage { get; set; }

        public int takenRows { get; set; }

        public int count { get; set; }
        public bool? GetAll { get; set; } = false;
    }
}
