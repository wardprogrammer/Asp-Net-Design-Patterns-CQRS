﻿using System;
using Agathas.Storefront.Infrastructure;

namespace Agathas.Storefront.Sales.Model.Baskets.Events
{
    public class BasketCreated : IDomainEvent
    {        
        public BasketCreated(Guid id, Money amountToPay)
        {
            Id = id;
            AmountToPay = amountToPay;
        }

        public Guid Id { get; set; }
        public Money AmountToPay { get; set; }
    }
}
