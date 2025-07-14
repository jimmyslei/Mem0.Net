using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mem0.NetCore.Options;

public class Mem0Options : IConfigureOptions<Mem0Options>
{
    public string Endpoint { get; set; }
    public string ApiKey { get; set; }
    public string OrganizationId { get; set; }
    public string ProjectId { get; set; }

    public void Configure(Mem0Options options)
    {
        options.Endpoint = Endpoint;
        options.ApiKey = ApiKey;
        options.OrganizationId = OrganizationId;
        options.ProjectId = ProjectId;
    }
}

