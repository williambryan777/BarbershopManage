using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DBUtility
{
    public static class FormHelper
    {
        #region 根据表单传过来的数据进行初始化对象

        /// <summary>
        ///     根据表单传过来的数据进行初始化对象
        /// </summary>
        /// <param name="model"> </param>
        /// <param name="nvc"> </param>
        /// <typeparam name="T"> </typeparam>
        public static void InitModel<T>(T model, NameValueCollection nvc)
        {
            PropertyInfo[] props = model.GetType().GetProperties();
            for (int i = 0; i < nvc.AllKeys.Length; i++)
            {
                foreach (var prop in props)
                {
                    if (nvc.Keys[i] == prop.Name)
                    {
                        if (prop.PropertyType.Name.Contains("Nullable"))
                        {
                            object keyValue = null;
                            if (!String.IsNullOrEmpty(nvc[prop.Name]))
                            {
                                keyValue = Convert.ChangeType(nvc[prop.Name].Trim(),
                                                              Nullable.GetUnderlyingType(prop.PropertyType));
                            }
                            prop.SetValue(model, keyValue, null);
                        }
                        else
                        {
                            object keyValue = Convert.ChangeType(nvc[prop.Name].Trim(), prop.PropertyType);
                            prop.SetValue(model, keyValue, null);
                        }
                    }
                }
            }
        }

        #endregion

        #region  时间格式化指定格式 yyyy-MM-dd HH:mm:ss

        /// <summary>
        ///     时间格式化指定格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="dt"> 时间 </param>
        /// <returns> 指定格式的时间类型 </returns>
        public static string GetTime(DateTime? dt)
        {
            if (dt == null)
            {
                return "";
            }
            return Convert.ToDateTime(dt).ToString("yyyy-MM-dd HH:mm:ss");
        }

        #endregion

        #region  时间格式化指定格式 yyyy-MM-dd

        /// <summary>
        ///     时间格式化指定格式 yyyy-MM-dd
        /// </summary>
        /// <param name="dt"> 时间 </param>
        /// <returns> 指定格式的时间类型 </returns>
        public static string GetDate(DateTime? dt)
        {
            if (dt == null)
            {
                return "";
            }
            return Convert.ToDateTime(dt).ToString("yyyy-MM-dd");
        }

        #endregion

        #region 通过StringBuilder输出Excel

        /// <summary>
        ///     通过StringBuilder输出Excel
        /// </summary>
        /// <param name="sb">StringBuilder对象</param>
        /// <param name="fileName">文件名</param>
        public static void ExportExcelBySB(StringBuilder sb, string fileName)
        {
            //输出EXCEL 
            HttpResponse httpResponse = HttpContext.Current.Response;
            httpResponse.Clear();
            httpResponse.Buffer = true;
            httpResponse.Charset = "gb2312";
            httpResponse.ContentEncoding = Encoding.GetEncoding("utf-8");
            httpResponse.AppendHeader("Content-Disposition",
                                      "attachment;filename=" + HttpUtility.UrlEncode(fileName, Encoding.UTF8));
            httpResponse.ContentType = "application/ms-excel";
            httpResponse.Write("<html><head><meta http-equiv=Content-Type content=\"text/html; charset=utf-8\">");
            httpResponse.Write(sb.ToString());
            httpResponse.End();
        }

        #endregion

        #region 获取json格式化的数据

        /// <summary>
        /// 获取json格式化的数据
        /// </summary>
        /// <param name="totalCount">总行数</param>
        /// <param name="obj">json字符串</param>
        /// <returns></returns>
        public static string GetJsonData(int totalCount, object obj)
        {
            string resJson = "{\"total\":" + totalCount + ",\"rows\":" + obj + "}";
            return resJson;
        }

        #endregion
    }
}
