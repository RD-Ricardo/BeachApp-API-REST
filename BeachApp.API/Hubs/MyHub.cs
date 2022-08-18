using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BeachApp.Domain.Entities;
using BeachApp.Domain.Interfaces.Generic;
using Microsoft.AspNetCore.SignalR;

namespace BeachApp.API.Hubs
{
    // public class MyHub : Hub
    // {
    //     private  readonly IGenericRepository<Product> _repository;
    //     public MyHub(IGenericRepository<Product> repository)
    //     {
    //        _repository = repository; 
    //     }
    //     public async Task<IEnumerable<Product>> Stre
    //     aming(CancellationToken cancellationToken)
    //     {
    //         while (true)
    //         {
    //             yield return  _repository.GetAllEntityAsync(null).ConfigureAwait(false);
    //             await Task.Delay(1000, cancellationToken);
    //         }
    //     }
    // }
}