// 本代码由代码生成器生成请勿随意改动
// 生成时间  2018-12-13 10:10:20
using System;

namespace Czar.Cms.Models
{
	/// <summary>
	/// yilezhu
	/// 2018-12-13 10:10:20
	/// 角色权限表
	/// </summary>
	public class RolePermission
	{
				/// <summary>
		/// 主键
		/// </summary>
		public Int32 Id {get;set;}

		/// <summary>
		/// 角色主键
		/// </summary>
		public Int32 RoleId {get;set;}

		/// <summary>
		/// 菜单主键
		/// </summary>
		public Int32 MenuId {get;set;}

		/// <summary>
		/// 操作类型（功能权限）
		/// </summary>
		public String Permission {get;set;}


	}
}
