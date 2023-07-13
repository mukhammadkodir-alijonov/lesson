namespace CarShop.Api.Common.Utils
{
    public class PaginationMetaData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int HasNext { get; set; }
        public int HasPrevious { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
}
