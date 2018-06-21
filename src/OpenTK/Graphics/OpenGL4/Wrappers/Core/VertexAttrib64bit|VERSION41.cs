//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="pname">
        /// </param>
        /// <param name="@params">
        /// [length: COMPSIZE(pname)]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glGetVertexAttribLdv")]
        public static void GetVertexAttribL(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] double[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="pname">
        /// </param>
        /// <param name="@params">
        /// [length: COMPSIZE(pname)]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glGetVertexAttribLdv")]
        public static void GetVertexAttribL(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out double @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="pname">
        /// </param>
        /// <param name="@params">
        /// [length: COMPSIZE(pname)]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glGetVertexAttribLdv")]
        public static unsafe void GetVertexAttribL(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] double* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="x">
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL1d")]
        public static void VertexAttribL1(uint index, double x)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 1]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL1dv")]
        public static void VertexAttribL1(uint index, [CountAttribute(Count = 1)] ref double v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 1]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL1dv")]
        public static unsafe void VertexAttribL1(uint index, [CountAttribute(Count = 1)] double* v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="x">
        /// </param>
        /// <param name="y">
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL2d")]
        public static void VertexAttribL2(uint index, double x, double y)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 2]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL2dv")]
        public static void VertexAttribL2(uint index, [CountAttribute(Count = 2)] double[] v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 2]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL2dv")]
        public static void VertexAttribL2(uint index, [CountAttribute(Count = 2)] ref double v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 2]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL2dv")]
        public static unsafe void VertexAttribL2(uint index, [CountAttribute(Count = 2)] double* v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="x">
        /// </param>
        /// <param name="y">
        /// </param>
        /// <param name="z">
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL3d")]
        public static void VertexAttribL3(uint index, double x, double y, double z)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 3]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL3dv")]
        public static void VertexAttribL3(uint index, [CountAttribute(Count = 3)] double[] v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 3]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL3dv")]
        public static void VertexAttribL3(uint index, [CountAttribute(Count = 3)] ref double v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 3]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL3dv")]
        public static unsafe void VertexAttribL3(uint index, [CountAttribute(Count = 3)] double* v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="x">
        /// </param>
        /// <param name="y">
        /// </param>
        /// <param name="z">
        /// </param>
        /// <param name="w">
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL4d")]
        public static void VertexAttribL4(uint index, double x, double y, double z, double w)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 4]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL4dv")]
        public static void VertexAttribL4(uint index, [CountAttribute(Count = 4)] double[] v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 4]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL4dv")]
        public static void VertexAttribL4(uint index, [CountAttribute(Count = 4)] ref double v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="v">
        /// [length: 4]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribL4dv")]
        public static unsafe void VertexAttribL4(uint index, [CountAttribute(Count = 4)] double* v)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="pointer">
        /// [length: size]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribLPointer")]
        public static void VertexAttribLPointer(uint index, int size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, int stride, [CountAttribute(Parameter = "size")] IntPtr pointer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="pointer">
        /// [length: size]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribLPointer")]
        public static void VertexAttribLPointer<T4>(uint index, int size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, int stride, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T4[] pointer)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="pointer">
        /// [length: size]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribLPointer")]
        public static void VertexAttribLPointer<T4>(uint index, int size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, int stride, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T4[,] pointer)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="pointer">
        /// [length: size]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribLPointer")]
        public static void VertexAttribLPointer<T4>(uint index, int size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, int stride, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T4[,,] pointer)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_vertex_attrib_64bit|VERSION_4_1]
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="pointer">
        /// [length: size]
        /// </param>
        [AutoGenerated(Category = "ARB_vertex_attrib_64bit|VERSION_4_1", Version = "4.1", EntryPoint = "glVertexAttribLPointer")]
        public static void VertexAttribLPointer<T4>(uint index, int size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, int stride, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] ref T4 pointer)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(594)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetVertexAttribLdv(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] double* @params);

        [Slot(1304)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribL1d(uint index, double x);

        [Slot(1305)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glVertexAttribL1dv(uint index, [CountAttribute(Count = 1)] double* v);

        [Slot(1312)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribL2d(uint index, double x, double y);

        [Slot(1313)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glVertexAttribL2dv(uint index, [CountAttribute(Count = 2)] double* v);

        [Slot(1318)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribL3d(uint index, double x, double y, double z);

        [Slot(1319)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glVertexAttribL3dv(uint index, [CountAttribute(Count = 3)] double* v);

        [Slot(1324)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribL4d(uint index, double x, double y, double z, double w);

        [Slot(1325)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glVertexAttribL4dv(uint index, [CountAttribute(Count = 4)] double* v);

        [Slot(1332)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribLPointer(uint index, int size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, int stride, [CountAttribute(Parameter = "size")] IntPtr pointer);
    }
}