using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SDLX.DBUtility;//������������
namespace SDLX.BLL
{
	/// <summary>
	/// ��ERPContract��
	/// </summary>
	public class ERPContract
	{
		public ERPContract()
		{}
		#region Model
		private int _id;
		private string _hetongname;
		private string _hetongserils;
		private string _hetongleixing;
		private string _qianyuekehu;
		private string _hetongmiaoshu;
		private string _hetongtiaokuan;
		private string _hetongcontent;
		private DateTime? _shengxiaodate;
		private DateTime? _zhongzhidate;
		private DateTime? _tixingdate;
		private string _qianyuerenbuy;
		private string _qianyuerensell;
		private DateTime? _createtime;
		private string _createuser;
		private string _fujianlist;
		private string _backinfo;
		private string _nowstate;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��ͬ����
		/// </summary>
		public string HeTongName
		{
			set{ _hetongname=value;}
			get{return _hetongname;}
		}
		/// <summary>
		/// ��ͬ���
		/// </summary>
		public string HeTongSerils
		{
			set{ _hetongserils=value;}
			get{return _hetongserils;}
		}
		/// <summary>
		/// ��ͬ����
		/// </summary>
		public string HeTongLeiXing
		{
			set{ _hetongleixing=value;}
			get{return _hetongleixing;}
		}
		/// <summary>
		/// ǩԼ�ͻ�
		/// </summary>
		public string QianYueKeHu
		{
			set{ _qianyuekehu=value;}
			get{return _qianyuekehu;}
		}
		/// <summary>
		/// ��ͬ����
		/// </summary>
		public string HeTongMiaoShu
		{
			set{ _hetongmiaoshu=value;}
			get{return _hetongmiaoshu;}
		}
		/// <summary>
		/// ��ͬ����
		/// </summary>
		public string HeTongTiaoKuan
		{
			set{ _hetongtiaokuan=value;}
			get{return _hetongtiaokuan;}
		}
		/// <summary>
		/// ��ͬ����
		/// </summary>
		public string HeTongContent
		{
			set{ _hetongcontent=value;}
			get{return _hetongcontent;}
		}
		/// <summary>
		/// ��Ч����
		/// </summary>
		public DateTime? ShengXiaoDate
		{
			set{ _shengxiaodate=value;}
			get{return _shengxiaodate;}
		}
		/// <summary>
		/// ��ֹ����
		/// </summary>
		public DateTime? ZhongZhiDate
		{
			set{ _zhongzhidate=value;}
			get{return _zhongzhidate;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? TiXingDate
		{
			set{ _tixingdate=value;}
			get{return _tixingdate;}
		}
		/// <summary>
		/// ǩԼ�ˣ��򷽣�
		/// </summary>
		public string QianYueRenBuy
		{
			set{ _qianyuerenbuy=value;}
			get{return _qianyuerenbuy;}
		}
		/// <summary>
		/// ǩԼ�ˣ�������
		/// </summary>
		public string QianYueRenSell
		{
			set{ _qianyuerensell=value;}
			get{return _qianyuerensell;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// �����ļ�
		/// </summary>
		public string FuJianList
		{
			set{ _fujianlist=value;}
			get{return _fujianlist;}
		}
		/// <summary>
		/// ��ע��Ϣ
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// ��ǰ״̬
		/// </summary>
		public string NowState
		{
			set{ _nowstate=value;}
			get{return _nowstate;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPContract(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HeTongName,HeTongSerils,HeTongLeiXing,QianYueKeHu,HeTongMiaoShu,HeTongTiaoKuan,HeTongContent,ShengXiaoDate,ZhongZhiDate,TiXingDate,QianYueRenBuy,QianYueRenSell,CreateTime,CreateUser,FuJianList,BackInfo,NowState ");
			strSql.Append(" FROM ERPContract ");
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
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				HeTongSerils=ds.Tables[0].Rows[0]["HeTongSerils"].ToString();
				HeTongLeiXing=ds.Tables[0].Rows[0]["HeTongLeiXing"].ToString();
				QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
				HeTongMiaoShu=ds.Tables[0].Rows[0]["HeTongMiaoShu"].ToString();
				HeTongTiaoKuan=ds.Tables[0].Rows[0]["HeTongTiaoKuan"].ToString();
				HeTongContent=ds.Tables[0].Rows[0]["HeTongContent"].ToString();
				if(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString()!="")
				{
					ShengXiaoDate=DateTime.Parse(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString()!="")
				{
					ZhongZhiDate=DateTime.Parse(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiXingDate"].ToString()!="")
				{
					TiXingDate=DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
				}
				QianYueRenBuy=ds.Tables[0].Rows[0]["QianYueRenBuy"].ToString();
				QianYueRenSell=ds.Tables[0].Rows[0]["QianYueRenSell"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				CreateUser=ds.Tables[0].Rows[0]["CreateUser"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPContract"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPContract");
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
			strSql.Append("insert into ERPContract(");
			strSql.Append("HeTongName,HeTongSerils,HeTongLeiXing,QianYueKeHu,HeTongMiaoShu,HeTongTiaoKuan,HeTongContent,ShengXiaoDate,ZhongZhiDate,TiXingDate,QianYueRenBuy,QianYueRenSell,CreateTime,CreateUser,FuJianList,BackInfo,NowState)");
			strSql.Append(" values (");
			strSql.Append("@HeTongName,@HeTongSerils,@HeTongLeiXing,@QianYueKeHu,@HeTongMiaoShu,@HeTongTiaoKuan,@HeTongContent,@ShengXiaoDate,@ZhongZhiDate,@TiXingDate,@QianYueRenBuy,@QianYueRenSell,@CreateTime,@CreateUser,@FuJianList,@BackInfo,@NowState)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongSerils", SqlDbType.VarChar,50),
					new SqlParameter("@HeTongLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongMiaoShu", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongTiaoKuan", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongContent", SqlDbType.Text),
					new SqlParameter("@ShengXiaoDate", SqlDbType.DateTime),
					new SqlParameter("@ZhongZhiDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@QianYueRenBuy", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueRenSell", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,500),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50)};
			parameters[0].Value = HeTongName;
			parameters[1].Value = HeTongSerils;
			parameters[2].Value = HeTongLeiXing;
			parameters[3].Value = QianYueKeHu;
			parameters[4].Value = HeTongMiaoShu;
			parameters[5].Value = HeTongTiaoKuan;
			parameters[6].Value = HeTongContent;
			parameters[7].Value = ShengXiaoDate;
			parameters[8].Value = ZhongZhiDate;
			parameters[9].Value = TiXingDate;
			parameters[10].Value = QianYueRenBuy;
			parameters[11].Value = QianYueRenSell;
			parameters[12].Value = CreateTime;
			parameters[13].Value = CreateUser;
			parameters[14].Value = FuJianList;
			parameters[15].Value = BackInfo;
			parameters[16].Value = NowState;

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
			strSql.Append("update ERPContract set ");
			strSql.Append("HeTongName=@HeTongName,");
			strSql.Append("HeTongSerils=@HeTongSerils,");
			strSql.Append("HeTongLeiXing=@HeTongLeiXing,");
			strSql.Append("QianYueKeHu=@QianYueKeHu,");
			strSql.Append("HeTongMiaoShu=@HeTongMiaoShu,");
			strSql.Append("HeTongTiaoKuan=@HeTongTiaoKuan,");
			strSql.Append("HeTongContent=@HeTongContent,");
			strSql.Append("ShengXiaoDate=@ShengXiaoDate,");
			strSql.Append("ZhongZhiDate=@ZhongZhiDate,");
			strSql.Append("TiXingDate=@TiXingDate,");
			strSql.Append("QianYueRenBuy=@QianYueRenBuy,");
			strSql.Append("QianYueRenSell=@QianYueRenSell,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("CreateUser=@CreateUser,");
			strSql.Append("FuJianList=@FuJianList,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("NowState=@NowState");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongSerils", SqlDbType.VarChar,50),
					new SqlParameter("@HeTongLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongMiaoShu", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongTiaoKuan", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongContent", SqlDbType.Text),
					new SqlParameter("@ShengXiaoDate", SqlDbType.DateTime),
					new SqlParameter("@ZhongZhiDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@QianYueRenBuy", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueRenSell", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,500),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = HeTongName;
			parameters[2].Value = HeTongSerils;
			parameters[3].Value = HeTongLeiXing;
			parameters[4].Value = QianYueKeHu;
			parameters[5].Value = HeTongMiaoShu;
			parameters[6].Value = HeTongTiaoKuan;
			parameters[7].Value = HeTongContent;
			parameters[8].Value = ShengXiaoDate;
			parameters[9].Value = ZhongZhiDate;
			parameters[10].Value = TiXingDate;
			parameters[11].Value = QianYueRenBuy;
			parameters[12].Value = QianYueRenSell;
			parameters[13].Value = CreateTime;
			parameters[14].Value = CreateUser;
			parameters[15].Value = FuJianList;
			parameters[16].Value = BackInfo;
			parameters[17].Value = NowState;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPContract ");
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
			strSql.Append("select  top 1 ID,HeTongName,HeTongSerils,HeTongLeiXing,QianYueKeHu,HeTongMiaoShu,HeTongTiaoKuan,HeTongContent,ShengXiaoDate,ZhongZhiDate,TiXingDate,QianYueRenBuy,QianYueRenSell,CreateTime,CreateUser,FuJianList,BackInfo,NowState ");
			strSql.Append(" FROM ERPContract ");
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
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				HeTongSerils=ds.Tables[0].Rows[0]["HeTongSerils"].ToString();
				HeTongLeiXing=ds.Tables[0].Rows[0]["HeTongLeiXing"].ToString();
				QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
				HeTongMiaoShu=ds.Tables[0].Rows[0]["HeTongMiaoShu"].ToString();
				HeTongTiaoKuan=ds.Tables[0].Rows[0]["HeTongTiaoKuan"].ToString();
				HeTongContent=ds.Tables[0].Rows[0]["HeTongContent"].ToString();
				if(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString()!="")
				{
					ShengXiaoDate=DateTime.Parse(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString()!="")
				{
					ZhongZhiDate=DateTime.Parse(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiXingDate"].ToString()!="")
				{
					TiXingDate=DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
				}
				QianYueRenBuy=ds.Tables[0].Rows[0]["QianYueRenBuy"].ToString();
				QianYueRenSell=ds.Tables[0].Rows[0]["QianYueRenSell"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				CreateUser=ds.Tables[0].Rows[0]["CreateUser"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPContract ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}
