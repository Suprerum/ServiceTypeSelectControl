using System.Collections.Generic;

namespace ServiceTypeService.Dto
{
    public class ServiceTypeDto
    {
        public ServiceTypeDto()
        {
            ChildrenList=new List<ServiceTypeDto>();
        }
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<ServiceTypeDto> ChildrenList { get; set; } 
    }
}
