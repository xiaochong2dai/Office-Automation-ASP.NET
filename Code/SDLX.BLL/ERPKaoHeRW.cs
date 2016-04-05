using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SDLX.DBUtility;//������������
namespace SDLX.BLL
{
	/// <summary>
	/// ��ERPKaoHeRW��
	/// </summary>
	public class ERPKaoHeRW
	{
		public ERPKaoHeRW()
		{}
		#region Model
		private int _id;
		private string _renwuname;
		private string _fenzhi;
		private string _renwuneirong;
		private string _backinfo;
		private string _username;
		private DateTime? _timestr;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string RenWuName
		{
			set{ _renwuname=value;}
			get{return _renwuname;}
		}
		/// <summary>
		/// ��ռ��ֵ
		/// </summary>
		public string FenZhi
		{
			set{ _fenzhi=value;}
			get{return _fenzhi;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string RenWuNeiRong
		{
			set{ _renwuneirong=value;}
			get{return _renwuneirong;}
		}
		/// <summary>
		/// ��ע˵��
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPKaoHeRW(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,RenWuName,FenZhi,RenWuNeiRong,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPKaoHeRW ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				RenWuName=ds.Tables[0].Rows[0]["RenWuName"].ToString();
				FenZhi=ds.Tables[0].Rows[0]["FenZhi"].ToString();
				RenWuNeiRong=ds.Tables[0].Rows[0]["RenWuNeiRong"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPKaoHeRW"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPKaoHeRW");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ERPKaoHeRW(");
			strSql.Append("RenWuName,FenZhi,RenWuNeiRong,BackInfo,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@RenWuName,@FenZhi,@RenWuNeiRong,@BackInfo,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@RenWuName", SqlDbType.VarChar,50),
					new SqlParameter("@FenZhi", SqlDbType.VarChar,50),
					new SqlParameter("@RenWuNeiRong", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = RenWuName;
			parameters[1].Value = FenZhi;
			parameters[2].Value = RenWuNeiRong;
			parameters[3].Value = BackInfo;
			parameters[4].Value = UserName;
			parameters[5].Value = TimeStr;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPKaoHeRW set ");
			strSql.Append("RenWuName=@RenWuName,");
			strSql.Append("FenZhi=@FenZhi,");
			strSql.Append("RenWuNeiRong=@RenWuNeiRong,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@RenWuName", SqlDbType.VarChar,50),
					new SqlParameter("@FenZhi", SqlDbType.VarChar,50),
					new SqlParameter("@RenWuNeiRong", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = RenWuName;
			parameters[2].Value = FenZhi;
			parameters[3].Value = RenWuNeiRong;
			parameters[4].Value = BackInfo;
			parameters[5].Value = UserName;
			parameters[6].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPKaoHeRW ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,RenWuName,FenZhi,RenWuNeiRong,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPKaoHeRW ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				RenWuName=ds.Tables[0].Rows[0]["RenWuName"].ToString();
				FenZhi=ds.Tables[0].Rows[0]["FenZhi"].ToString();
				RenWuNeiRong=ds.Tables[0].Rows[0]["RenWuNeiRong"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPKaoHeRW ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}
