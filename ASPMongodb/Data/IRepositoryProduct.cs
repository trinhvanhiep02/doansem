using ASPMongodb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Data
{
    interface IRepositoryProduct: IRepositoryGenneric<Product, int>
    {
        List<Product> Paping(int page, int pagesize, out long totalrows);
        List<Product> SearchPaging(string name, int page, int pagesize, out long totalrows);


    }
}
