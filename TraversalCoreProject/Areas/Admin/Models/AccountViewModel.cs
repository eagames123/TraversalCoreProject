namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int SenderId { get; set; }

        public int ReciverId { get; set; }

        public decimal Amount { get; set; }

        public decimal SenderNewBalance { get; set; }

        public decimal ReciverNewBalance { get; set; }
    }
}
