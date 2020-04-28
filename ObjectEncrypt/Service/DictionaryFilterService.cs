using ObjectHashGenerator.Contexts;

namespace ObjectHashGenerator.Services
{
    public class DictionaryFilterService
    {
        private readonly ConvertContext _context;
        public DictionaryFilterService(ConvertContext context)
        {
            _context = context;
        }


    }
}
