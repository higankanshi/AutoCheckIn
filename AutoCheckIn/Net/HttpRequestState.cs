﻿// Project: AutoCheckIn (https://github.com/higankanshi/AutoCheckIn)
// Filename: HttpRequestState.cs
// Version: 20160411

namespace AutoCheckIn.Net
{
    /// <summary>
    ///     表示 HTTP 请求的状态。
    /// </summary>
    public enum HttpRequestState
    {
        /// <summary>
        ///     HTTP 请求处于普通状态，这代表请求已经被构造，但是还未开始发起连接。
        /// </summary>
        NothingSpecial,

        /// <summary>
        ///     HTTP 请求正在与服务器链接，这代表请求正在连接服务器，但是还未开始下载。
        /// </summary>
        Connecting,

        /// <summary>
        ///     HTTP 请求正在传输数据。
        /// </summary>
        Progressing,

        /// <summary>
        ///     HTTP 请求已完成。
        /// </summary>
        Completed,

        /// <summary>
        ///     HTTP 请求在传输过程中发生错误，通过检查错误编号与异常来获取具体信息。
        /// </summary>
        ErrorOccurred,

        /// <summary>
        ///     HTTP 请求被主动取消。
        /// </summary>
        Cancelled
    }
}