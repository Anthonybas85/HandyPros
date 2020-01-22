namespace Business.Comm
{

    #region Permission List
    public class PermissionList
    {
        //ES// TODO Remove Unused Permissions
        public enum Permissions
        {
            LOOKUP_READ = 1,
            LOOKUP_WRITE,
            APPLICATION_READ,
            APPLICATION_WRITE,
            USERGROUP_READ,
            USERGROUP_WRITE,
            USER_READ,
            USER_WRITE,
            BROKERAGE_READ,
            BROKERAGE_WRITE,
            BROKER_READ,
            BROKER_WRITE,
            LENDER_READ,
            LENDER_WRITE,
            SYSTEMSECURITY_READ,
            SYSTEMSECURITY_WRITE,
            TOOLS_READ,
            TOOLS_WRITE,
            REPORTS_READ,
            REPORTS_WRITE,
            SYSTEM_READ,
            SYSTEM_WRITE
        }
    }
    #endregion

    public class Permission
    {
        public Permission() { }


        #region User role type permission
        //ES// TODO Remove Unused User role type permission
        //public System.Collections.ArrayList RegionalAdminFullPermissionList
        //{
        //    get
        //    {
        //        System.Collections.ArrayList list = new System.Collections.ArrayList();
        //        list.Add(PermissionList.Permissions.LOOKUP_READ);
        //        list.Add(PermissionList.Permissions.APPLICATION_READ);
        //        list.Add(PermissionList.Permissions.USERGROUP_READ);
        //        list.Add(PermissionList.Permissions.USER_READ);
        //        list.Add(PermissionList.Permissions.BROKER_READ);
        //        list.Add(PermissionList.Permissions.BROKERAGE_READ);

        //        list.Add(PermissionList.Permissions.BROKERAGE_WRITE);
        //        list.Add(PermissionList.Permissions.BROKER_WRITE);

        //        return list;
        //    }
        //}
        //public System.Collections.ArrayList RegionalAdminPermissionList
        //{
        //    get
        //    {
        //        System.Collections.ArrayList list = new System.Collections.ArrayList();
        //        list.Add(PermissionList.Permissions.LOOKUP_READ);
        //        list.Add(PermissionList.Permissions.APPLICATION_READ);
        //        list.Add(PermissionList.Permissions.USERGROUP_READ);
        //        list.Add(PermissionList.Permissions.USER_READ);
        //        list.Add(PermissionList.Permissions.BROKER_READ);
        //        list.Add(PermissionList.Permissions.BROKERAGE_READ);

        //        list.Add(PermissionList.Permissions.BROKERAGE_WRITE);
        //        list.Add(PermissionList.Permissions.BROKER_WRITE);

        //        return list;
        //    }
        //}
        //public System.Collections.ArrayList LookupAdminPermissionList
        //{
        //    get
        //    {
        //        System.Collections.ArrayList list = new System.Collections.ArrayList();
        //        list.Add(PermissionList.Permissions.LOOKUP_READ);
        //        list.Add(PermissionList.Permissions.APPLICATION_READ);
        //        list.Add(PermissionList.Permissions.USERGROUP_READ);
        //        list.Add(PermissionList.Permissions.USER_READ);
        //        list.Add(PermissionList.Permissions.BROKER_READ);
        //        list.Add(PermissionList.Permissions.BROKERAGE_READ);
        //        return list;
        //    }
        //}

        public System.Collections.ArrayList SuperUserPermissionList
        {
            get
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add(PermissionList.Permissions.BROKER_READ);
                list.Add(PermissionList.Permissions.BROKER_WRITE);

                list.Add(PermissionList.Permissions.BROKERAGE_READ);
                list.Add(PermissionList.Permissions.BROKERAGE_WRITE);

                list.Add(PermissionList.Permissions.LENDER_READ);
                list.Add(PermissionList.Permissions.LENDER_WRITE);

                list.Add(PermissionList.Permissions.SYSTEMSECURITY_READ);
                list.Add(PermissionList.Permissions.SYSTEMSECURITY_WRITE);

                list.Add(PermissionList.Permissions.TOOLS_READ);
                list.Add(PermissionList.Permissions.TOOLS_WRITE);

                list.Add(PermissionList.Permissions.REPORTS_READ);
                list.Add(PermissionList.Permissions.REPORTS_WRITE);

                list.Add(PermissionList.Permissions.SYSTEM_READ);
                list.Add(PermissionList.Permissions.SYSTEM_WRITE);

                return list;
            }
        }
        public System.Collections.ArrayList RecordsAdminReadOnlyPermissionList
        {
            get
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add(PermissionList.Permissions.BROKER_READ);

                list.Add(PermissionList.Permissions.REPORTS_READ);

                return list;
            }
        }
        public System.Collections.ArrayList RecordsAdminReadWritePermissionList
        {
            get
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add(PermissionList.Permissions.BROKER_READ);
                list.Add(PermissionList.Permissions.BROKER_WRITE);

                list.Add(PermissionList.Permissions.BROKERAGE_READ);
                list.Add(PermissionList.Permissions.BROKERAGE_WRITE);

                list.Add(PermissionList.Permissions.TOOLS_READ);
                list.Add(PermissionList.Permissions.TOOLS_WRITE);

                list.Add(PermissionList.Permissions.REPORTS_READ);
                list.Add(PermissionList.Permissions.REPORTS_WRITE);

                return list;
            }
        }
        public System.Collections.ArrayList RecordsAdminLimitedPermissionList
        {
            get
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add(PermissionList.Permissions.BROKER_READ);
                list.Add(PermissionList.Permissions.BROKER_WRITE);

                list.Add(PermissionList.Permissions.REPORTS_READ);
                list.Add(PermissionList.Permissions.REPORTS_WRITE);
                return list;
            }
        }
        #endregion

        public bool checkPermission(PermissionList.Permissions permission, int userId)
        {
            int userTypeId = 0;
           // UserService uSvc = new SUserService(userId);
            //userTypeId = uSvc.getUserTypeIdsByUserId(userId);

            //if (userTypeId == BLL.MainConfig.BrokerDirectory.USERROLETYPE_SUPERADMIN)
            //{
            //    return true;
            //}
            //else if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_REGIONALADMINFULL)
            //{
            //    return RegionalAdminFullPermissionList.Contains(permission);
            //}
            //else if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_REGIONALADMIN)
            //{
            //    return RegionalAdminPermissionList.Contains(permission);
            //}
            //else if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_LOOKUPADMIN)
            //{
            //    return LookupAdminPermissionList.Contains(permission);
            //}

            if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_SUPERUSER)
            {
                return true;
            }
            else if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_RECORDSADMINRO)
            {
                return RecordsAdminReadOnlyPermissionList.Contains(permission);
            }
            else if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_RECORDSADMINRW)
            {
                return RecordsAdminReadWritePermissionList.Contains(permission);
            }
            else if (userTypeId == MainConfig.BrokerDirectory.USERROLETYPE_RECORDSADMINLIMITED)
            {
                return RecordsAdminLimitedPermissionList.Contains(permission);
            }

            return false;
        }
    }
}
