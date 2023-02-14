using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Branch
    {
        private Int32 id;
        private String branchName;
        private Shop shop;
        private Int32 status;

        public Branch()
        {

        }

        public Branch(int id, string branchName, Shop shop, int status)
        {
            this.Id = id;
            this.BranchName = branchName;
            this.Shop = shop;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public string BranchName { get => branchName; set => branchName = value; }
        internal Shop Shop { get => shop; set => shop = value; }
        public int Status { get => status; set => status = value; }

        public static ReturnResult store(Branch branch)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `branches` " +
                    "(`branch_name`,`shop_id`,`status`) VALUES (@branch_name,@shop_id,@status)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("branch_name", MySqlDbType.String, branch.BranchName));
                parameters.Add(new QueryParameter("shop_id", MySqlDbType.Int32, branch.Shop.Id));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, branch.Status));

                commands.Add(new QueryCommand(sql, parameters));
                result = DBTransactionService.executeNonQuery(commands);
                if (result.Status)

                    result.Msg = Constants.MSG_STORE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }

        public static ReturnResult update(Branch branch)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `branches` SET " +
                    "`branch_name` = @branch_name, " +
                    "`shop_id` = @shop_id, " +
                    "`status` = @status, " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("branch_name", MySqlDbType.String, branch.BranchName));
                parameters.Add(new QueryParameter("shop_id", MySqlDbType.Int32, branch.Shop.Id));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, branch.Status));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, branch.Id));

                commands.Add(new QueryCommand(sql, parameters));
                result = DBTransactionService.executeNonQuery(commands);
                if (result.Status)
                    result.Msg = Constants.MSG_UPDATE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }

        public static ReturnResult delete(int id)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string query = "DELETE FROM `branches` WHERE id = @id";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, id));
                commands.Add(new QueryCommand(query, parameters));
                result = DBTransactionService.executeNonQuery(commands);
                if (result.Status)
                    result.Msg = Constants.MSG_DELETE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }

        //public static void showOnViewForm()
        //{
        //    DataViewParam dvParam = new DataViewParam();
        //    dvParam.Title = "Job Roles";
        //    dvParam.SelectSql = "SELECT id, code, tittle, description ";
        //    dvParam.FromSql = "from job_role where tittle like @s1 or code like @s2 ORDER BY id DESC ";
        //    dvParam.SearchParamCount = 2; //name and description
        //    dvParam.TitleList = new List<string>() { "", "Code", "Job Role", "Description" }; //Column titles
        //    dvParam.AddForm = new JobRoleManagement();
        //    dvParam.ViewForm = new ViewSingleJobRole();
        //    ViewData vData = new ViewData(dvParam);
        //    vData.Show();
        //}

        public static Branch getOneBranch(int id)
        {
            Branch branch = new Branch();
            Shop shop = new Shop();
            try
            {
                String query = "SELECT * FROM branches where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    branch.BranchName = dbData["branch_name"];
                    branch.Shop = shop;
                    branch.Status = Convert.ToInt32(dbData["status"]);
                }
                else
                {
                    //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return branch;
        }
    }
}
