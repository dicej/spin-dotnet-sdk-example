// Generated by `wit-bindgen` 0.28.0. DO NOT EDIT!
// <auto-generated />
#nullable enable

using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace SpinHttpWorld.wit.exports.wasi.http.v0_2_0
{
    public static class IncomingHandlerInterop {

        [UnmanagedCallersOnly(EntryPoint = "wasi:http/incoming-handler@0.2.0#handle")]
        public static unsafe void wasmExportHandle(int p0, int p1) {

            var resource = new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_0.ITypes.IncomingRequest(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_0.ITypes.IncomingRequest.THandle(p0));
            var resource0 = new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_0.ITypes.ResponseOutparam(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_0.ITypes.ResponseOutparam.THandle(p1));
            IncomingHandlerImpl.Handle((resource), (resource0));

        }

    }
}
