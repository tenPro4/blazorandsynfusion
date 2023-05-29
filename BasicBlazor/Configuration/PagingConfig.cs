namespace BasicBlazor.Configuration
{
    public class PagingConfig
    {
        public bool Enabled { get; set; }
        public int PageSize { get; set; }
        public bool CustomPager { get; set; }

        public int NumToSkip(int page)
        {
            if(Enabled)
                return (page - 1) * PageSize;

            return 0;
        }

        public int NumToTake(int take)
        {
            if (Enabled)
                return PageSize;

            return take;
        }

        public int PrePage(int currentPage)
        {
            if (currentPage > 1)
                return currentPage - 1;
            else
                return 1;
        }

        public int NextPage(int currentPage,int total)
        {
            if (currentPage < MaxPage(total))
                return currentPage + 1;
            else
                return currentPage;
        }

        public int MaxPage(int total)
        {
            int maxNumber;
            double numberOfPages = (double)total/(double)PageSize;
            if(numberOfPages == Math.Floor(numberOfPages))
                maxNumber = (int)numberOfPages;
            else
                maxNumber = (int)numberOfPages + 1;

            return maxNumber;
        }
    }
}
