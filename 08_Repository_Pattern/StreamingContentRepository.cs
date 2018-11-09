using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern
{
    public class StreamingContentRepository
    {
        List<StreamingContent> _listOfContent = new List<StreamingContent>();

        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }
    }
}
