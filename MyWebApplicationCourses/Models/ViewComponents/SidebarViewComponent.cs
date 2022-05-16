﻿using Microsoft.AspNetCore.Mvc;
using MyWebApplicationCourses.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplicationCourses.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
