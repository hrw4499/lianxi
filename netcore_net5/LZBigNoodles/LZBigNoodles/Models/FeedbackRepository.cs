using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.Models
{
    public class FeedbackRepository:IFeedbackRepository
    {
        private readonly AppDbContext _context;
        public FeedbackRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            feedback.CreateDateUTC = System.DateTime.Now;
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();

        }

        public IEnumerable<Feedback> GETALLFeedbacks()
        {
            return _context.Feedbacks;
        }
    }
}
