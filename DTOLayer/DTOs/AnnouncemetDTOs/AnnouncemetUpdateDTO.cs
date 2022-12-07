using System;

namespace DTOLayer.DTOs.AnnouncemetDTOs
{
    public class AnnouncemetUpdateDTO
    {
        public int AnnouncemetId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }
    }
}
