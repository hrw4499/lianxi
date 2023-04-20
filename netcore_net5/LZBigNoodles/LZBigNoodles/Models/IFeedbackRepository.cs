using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GETALLFeedbacks();
        void AddFeedback(Feedback feedback);
    }
}
