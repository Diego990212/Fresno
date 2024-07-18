using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Booty_Fresno.Classes;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Booty_Fresno.Classes;
using System.Reflection.Emit;

namespace Booty_Fresno.Controllers
{
    public class ProductsController : Controller
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] Message Body)
        {
            List<Return.Message> Messages = new List<Return.Message>();
            List<Return.Entry._List._Options> OptionList = new List<Return.Entry._List._Options>();
            Return Response = new Return();
            try
            {
                if (Body.Status == 0)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor escribe la clave del producto."
                        }
                    });

                    Response.Question = new Return.Entry
                    {
                        Input = new Return.Entry._Input
                        {
                            Text = new Return.Entry._Input._Text
                            {
                                Placeholder = "MAQxxxxxxx"
                            }
                        }
                    };
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 1
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 1)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor escribe el numero de serie."
                        }
                    });

                    Response.Question = new Return.Entry
                    {
                        Input = new Return.Entry._Input
                        {
                            Text = new Return.Entry._Input._Text
                            {
                                Placeholder = "SERxxxxxxxxxxx"
                            }
                        }
                    };
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 2
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 2)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor escribe el nombre del producto."
                        }
                    });

                    Response.Question = new Return.Entry
                    {
                        Input = new Return.Entry._Input
                        {
                            Text = new Return.Entry._Input._Text
                            {
                                Placeholder = "MOTOR xxxx xxxx"
                            }
                        }
                    };
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 3
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 3)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor escribe la descripcion del producto."
                        }
                    });

                    Response.Question = new Return.Entry
                    {
                        Input = new Return.Entry._Input
                        {
                            Text = new Return.Entry._Input._Text
                            {
                                Placeholder = "MOTOR xxxx xxxx xxxx"
                            }
                        }
                    };
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 4
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 4)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor ingresa el precio del producto."
                        }
                    });

                    Response.Question = new Return.Entry
                    {
                        Input = new Return.Entry._Input
                        {
                            Number = new Return.Entry._Input._Number
                            {
                                
                            }
                        }
                    };
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 5
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 5)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor ingresa el stock actual del producto."
                        }
                    });

                    Response.Question = new Return.Entry
                    {
                        Input = new Return.Entry._Input
                        {
                            Number = new Return.Entry._Input._Number
                            {

                            }
                        }
                    };
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 6
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 6)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor ingresa el tipo de moneda."
                        }
                    });

                    //INGRESO DE TIPO DE MONEDA EN CHECKBOX
                    Response.Answers = Messages;
                    Response.Question = new Return.Entry
                    {
                         List = new Return.Entry._List
                         {
                             Options = new List<Return.Entry._List._Options>
                             {
                                 new Return.Entry._List._Options
                                 {
                                      Value = "USD"
                                 },
                                 new Return.Entry._List._Options
                                 {
                                     Value = "MXN"
                                 }
                             }
                         }
                    };
                    Response.Parameters = new Return.Options
                    {
                        Status = 7
                    };

                    return Ok(Response);
                }
                else if (Body.Status == 7)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Por favor ingresa la imagen del producto."
                        }
                    });

                    //INGRESO DE TIMAGEN DE PRODUCTO
                    Response.Answers = Messages;
                    Response.Question = new Return.Entry
                    {
                        File = new Return.Entry._File
                        {
                            Label = "Seleccionar Imagen del producto",
                            Multiple = false
                        }
                    };

                    Response.Parameters = new Return.Options
                    {
                        Status = 8
                    };

                    return Ok(Response);
                }
                else if (Body.Status == 8)
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "✅El producto se guardo exitosamente✅, ¿Desea ingresar un nuevo producto?"
                        }
                    });

                    Response.Answers = Messages;
                    Response.Question = new Return.Entry
                    {
                        List = new Return.Entry._List
                        {
                            Options = new List<Return.Entry._List._Options>
                             {
                                 new Return.Entry._List._Options
                                 {
                                      Value = "SI"
                                 },
                                 new Return.Entry._List._Options
                                 {
                                     Value = "NO"
                                 }
                             }
                        }
                    };
                   
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = 9
                    };
                    return Ok(Response);
                }
                else if (Body.Status == 9)
                {
                    if (Body.Text == "SI")
                    {
                        Messages.Add(new Return.Message
                        {
                            Text = new Return.Message._Text
                            {
                                Text = "Por favor escribe la clave del producto."
                            }
                        });

                        Response.Question = new Return.Entry
                        {
                            Input = new Return.Entry._Input
                            {
                                Text = new Return.Entry._Input._Text
                                {
                                    Placeholder = "MAQxxxxxxx"
                                }
                            }
                        };
                        Response.Answers = Messages;
                        Response.Parameters = new Return.Options
                        {
                            Status = 1
                        };
                        return Ok(Response);
                    }
                    else
                    {
                        Messages.Add(new Return.Message
                        {
                            Text = new Return.Message._Text
                            {
                                Text = "Flujo finalizado, puede comenzar de nuevo"
                            }
                        });
                        Response.Answers = Messages;
                        Response.Parameters = new Return.Options
                        {
                            Status = -1
                        };
                        return Ok(Response);
                    }
                }
                else
                {
                    Messages.Add(new Return.Message
                    {
                        Text = new Return.Message._Text
                        {
                            Text = "Flujo finalizado, puede comenzar de nuevo"
                        }
                    });
                    Response.Answers = Messages;
                    Response.Parameters = new Return.Options
                    {
                        Status = -1
                    };
                    return Ok(Response);
                }
            }
            catch (Exception ex)
            {
                Messages.Add(new Return.Message
                {
                    Text = new Return.Message._Text
                    {
                        Text = "Ocurrio un error durante el procesamiento en el flujo"
                    }
                });
                Messages.Add(new Return.Message
                {
                    Text = new Return.Message._Text
                    {
                        Text = ex.Message
                    }
                });
                Response.Answers = Messages;
                Response.Parameters = new Return.Options
                {
                    Status = -1
                };
                return Ok(Response);
            }
        }
    }
}
