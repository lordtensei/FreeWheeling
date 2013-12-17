﻿using FreeWheeling.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeWheeling.UI.Models
{

    public class GroupModel
    {
        public string Name;
        public List<Group> _Groups;
        public List<int> CurrentGroupMembership;
        public List<NextRideDetails> _NextRideDetails;
        public string UserLocation;
        public string title;
    }

    public class DayOfWeekViewModel
    {
        public string Name { get; set; }
        public bool Checked { get; set; }
    }
        
    public class GroupCreateModel
    {

    public GroupCreateModel()
    {
        DaysOfWeek = new[]
        {
            new DayOfWeekViewModel { Name = "Monday" },
            new DayOfWeekViewModel { Name = "Tuesday" },
            new DayOfWeekViewModel { Name = "Wednesday" },
            new DayOfWeekViewModel { Name = "Thursday" },
            new DayOfWeekViewModel { Name = "Friday" },
            new DayOfWeekViewModel { Name = "Saturday" },
            new DayOfWeekViewModel { Name = "Sunday" },
        }.ToList();
    }

    public string AM_PM { get; set; }
    public IEnumerable<SelectListItem> AM_PMList
    {
        get
        {
            return new[]
            {
                new SelectListItem { Value = "AM", Text = "AM" },
                new SelectListItem { Value = "PM", Text = "PM" }
            };
        }
    }
    [Required]
    public IList<DayOfWeekViewModel> DaysOfWeek { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Hour { get; set; }
    [Required]
    public int Minute { get; set; }
    [Required]
    public int LocationsId { get; set; }
    public List<Location> Locations { get; set; }

    }

    public class MyGroupsModel
    {
        public int id { get; set; }
        public List<Group> CycleGroups { get;set; }

    }

    public class NextRideDetails
    {
        public int GroupId { get; set; }
        public DateTime Date { get; set; }
        public int NumberofRiders { get; set; }
    }
}