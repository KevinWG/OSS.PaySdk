﻿#region Copyright (C) 2021 Kevin (OSS开源实验室) 公众号：osscore

/***************************************************************************
*　　	文件功能描述：微信支付模快 —— 配置提供者
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*    	创建日期：2021-7-21
*       
*****************************************************************************/

#endregion


using OSS.Clients.Pay.Wechat.Basic.Certificate.Interface;
using System;
using System.Net.Http;

namespace OSS.Clients.Pay.Wechat
{
    public static class WechatPayHelper
    {
        /// <summary>
        ///  接口请求域名，默认生产环境：https://api.mch.weixin.qq.com
        ///     如果需要测试，可自行修改为沙箱环境地址
        /// </summary>
        public static string api_domain { get; set; } = "https://api.mch.weixin.qq.com";

        /// <summary>
        ///  支付配置信息
        /// </summary>
        public static WechatPayConfig pay_config { get; set; }
        
        /// <summary>
        ///     自定义底层HttpClient的实现，不设置则使用默认实现
        /// </summary>
        public static IHttpClientFactory httpclient_factory { get; set; }

        /// <summary>
        ///  【可选参数】微信平台放公钥证书提供者
        ///    系统默认实现懒加载（需要验签或者加密时加载内存中并缓存
        /// </summary>
        public static IWechatCertificateProvider WechatPublicCertificateProvider { get; set; }
    }
}
