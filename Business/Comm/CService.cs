using System;

namespace Business.Comm
{
    public class CService
    {
        public int _userId;
        public int _brokerId;

        public CService()
        {
        }

        public CService(int userID, int brokerID)
        {
            _userId = userID;
            _brokerId = brokerID;
        }

        public DateTime GetServerDateTime()
        {
            return DateTime.Now;
            //using (ISession session = _SessionFactory.OpenSession())
            //{
            //    ISQLQuery sqlQuery = session.CreateSQLQuery("select getdate()");
            //    return sqlQuery.UniqueResult<DateTime>();
            //}
        }
        public bool checkPermission(PermissionList.Permissions Permission)
        {
            Permission p = new Permission();
            return p.checkPermission(Permission, this._userId);
        }
    }
}
