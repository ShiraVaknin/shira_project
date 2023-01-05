using Microsoft.EntityFrameworkCore;
using Shira.Repositories.Entities;
using Shira.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.DataContex
{
    public class DataContext : DbContext, IContext
    {
        
    }
}
