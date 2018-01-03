using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AjaxLoadData(int pageSize = 10, int pageIndex = 1)
        {
            var result = new List<object>()
            {
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                },
                new
                {
                    field1 = "field1",
                    field2 = "field2",
                    field3 = "field3",
                    field4 = "field4",
                    field5 = "field5"
                }
            };
            var list = result.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            var total = result.Count;
            var pageCount = Math.Ceiling((double)total / pageSize);
            return Json(new { rows = list, total, pageSize, pageIndex, pageCount });
        }

        public IActionResult Tree()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AjaxLoadTree()
        {
            var rows = new List<object>()
            {
                new
                {
                    nodeId=Guid.NewGuid().ToString(),
                    text="父级1",
                    children = new List<object>()
                    {
                        new
                        {
                            nodeId=Guid.NewGuid().ToString(),
                            text="子级1",
                            children = new List<object>()
                            {
                                new
                                {
                                    nodeId=Guid.NewGuid().ToString(),
                                    text="子级2",
                                    children = new List<object>()
                                    {
                                        new
                                        {
                                            nodeId=Guid.NewGuid().ToString(),
                                            text="子级3",
                                            children = new List<object>()
                                            {
                                                new
                                                {
                                                    nodeId=Guid.NewGuid().ToString(),
                                                    text="子级4",
                                                    children = (object)null
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new
                {
                    nodeId=Guid.NewGuid().ToString(),
                    text="父级2",
                    children = (object)null
                },
                new
                {
                    nodeId=Guid.NewGuid().ToString(),
                    text="父级3",
                    children = (object)null
                },
                new
                {
                    nodeId=Guid.NewGuid().ToString(),
                    text="父级4",
                    children = (object)null
                },
                new
                {
                    nodeId=Guid.NewGuid().ToString(),
                    text="父级5",
                    children = (object)null
                }
            };
            return Json(new { success = true, rows });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
