﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
    public class CategoryEventDto
    {
        public Guid EventId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Artist { get; set; }

        public DateTime Date { get; set; }

        public Guid CategoryId { get; set; }
    }
}