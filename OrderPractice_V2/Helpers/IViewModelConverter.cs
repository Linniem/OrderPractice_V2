using OrderPractice_V2.Models;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Helpers
{
    public interface IViewModelConverter
    {
        IEnumerable<U> ConvertAllGeneric<T, U>(IEnumerable<T> modelList, Func<T, U> predicate);
        public OrderVm OrderConvertOne(Order order);
        public ShipInfoVm ShipInfoConvertOne(ShipInfo shipInfo);
    }
}
