﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{
    [AttributeUsage(AttributeTargets.Method)]
    public class BaseActionAttribute : Attribute
    {

        private string action = null;
        public virtual string Action
        {
            get { return action; }
        }
    }

    public class QueryActionAttribute : BaseActionAttribute
    {
        public override string Action
        {
            get
            {
                return "query";
            }
        }
    }

    public class EditActionAttribute : BaseActionAttribute
    {
        public override string Action
        {
            get
            {
                return "edit";
            }
        }
    }

    public class DeleteActionAttribute : BaseActionAttribute
    {
        public override string Action
        {
            get
            {
                return "delete";
            }
        }
    }

    public class ChangePasswordActionAttribute : BaseActionAttribute
    {
        public override string Action
        {
            get
            {
                return "changepassword";
            }
        }
    }
}
