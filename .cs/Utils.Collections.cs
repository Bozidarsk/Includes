using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;

using Utils;
using Utils.Web;

namespace Utils.Collections 
{
	public class Vector3 
    {
        public float x { set; get; }
        public float y { set; get; }
        public float z { set; get; }

        public bool Contains(List<Vector3> list) 
		{
			int i = 0;
			while (i < list.Count) 
			{
				if (list[i].x == x && list[i].y == y && list[i].z == z) { return true; }
				i++;
			}

			return false;
		}

		public int IndexOf(List<Vector3> list) 
		{
			int i = 0;
			while (i < list.Count) 
			{
				if (list[i].x == x && list[i].y == y && list[i].z == z) { return i; }
				i++;
			}

			return -1;
		}

		public int LastIndexOf(List<Vector3> list) 
		{
			int i = list.Count;
			while (i >= 0) 
			{
				if (list[i].x == x && list[i].y == y && list[i].z == z) { return i; }
				i--;
			}

			return -1;
		}

		public int CountInList(List<Vector3> list) 
		{
			int i = 0;
			int count = 0;
			while (i < list.Count) 
			{
				if (list[i].x == x && list[i].y == y && list[i].z == z) { count++; }
				i++;
			}

			return count;
		}

        public static readonly Vector3 zero = new Vector3(0, 0, 0);
        public static readonly Vector3 one = new Vector3(1, 1, 1);
        public static readonly Vector3 back = new Vector3(0, 0, -1f);
        public static readonly Vector3 down = new Vector3(0, -1f, 0);
        public static readonly Vector3 forward = new Vector3(0, 0, 1f);
        public static readonly Vector3 left = new Vector3(-1f, 0, 0);
        public static readonly Vector3 right = new Vector3(1f, 0, 0);
        public static readonly Vector3 up = new Vector3(0, 1f, 0);

        public static Vector3 operator * (Vector3 a, float x) { return new Vector3(a.x * x, a.y * x, a.z * x); }
        public static Vector3 operator * (float x, Vector3 a) { return new Vector3(a.x * x, a.y * x, a.z * x); }

        public static Vector3 operator / (Vector3 a, float x)
        {
            if (x == 0f) { throw new DivideByZeroException(); }
            return new Vector3(a.x / x, a.y / x, a.z / x);
        }

        public static Vector3 operator / (float x, Vector3 a)
        {
            if (x == 0f) { throw new DivideByZeroException(); }
            return new Vector3(a.x / x, a.y / x, a.z / x);
        }

        public static Vector3 operator + (Vector3 a, Vector3 b) { return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z); }
        public static Vector3 operator - (Vector3 a, Vector3 b) { return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z); }

        public Vector3(float x, float y, float z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public class Vector2 
    {
        public float x { set; get; }
        public float y { set; get; }

		public int IndexOf(List<Vector3> list) 
		{
			int i = 0;
			while (i < list.Count) 
			{
				if (list[i].x == x && list[i].y == y) { return i; }
				i++;
			}

			return -1;
		}

		public int LastIndexOf(List<Vector3> list) 
		{
			int i = list.Count;
			while (i >= 0) 
			{
				if (list[i].x == x && list[i].y == y) { return i; }
				i--;
			}

			return -1;
		}

		public int CountInList(List<Vector2> list) 
		{
			int i = 0;
			int count = 0;
			while (i < list.Count) 
			{
				if (list[i].x == x && list[i].y == y) { count++; }
				i++;
			}

			return count;
		}

        public static readonly Vector2 zero = new Vector2(0, 0);
        public static readonly Vector2 one = new Vector2(1, 1);
        public static readonly Vector2 down = new Vector2(0, -1f);
        public static readonly Vector2 left = new Vector2(-1f, 0);
        public static readonly Vector2 right = new Vector2(1f, 0);
        public static readonly Vector2 up = new Vector2(0, 1f);

        public static Vector2 operator * (Vector2 a, float x) { return new Vector2(a.x * x, a.y * x); }
        public static Vector2 operator * (float x, Vector2 a) { return new Vector2(a.x * x, a.y * x); }

        public static Vector2 operator / (Vector2 a, float x)
        {
            if (x == 0f) { throw new DivideByZeroException(); }
            return new Vector2(a.x / x, a.y / x);
        }

        public static Vector2 operator / (float x, Vector2 a)
        {
            if (x == 0f) { throw new DivideByZeroException(); }
            return new Vector2(a.x / x, a.y / x);
        }

        public static Vector2 operator + (Vector2 a, Vector2 b) { return new Vector2(a.x + b.x, a.y + b.y); }
        public static Vector2 operator - (Vector2 a, Vector2 b) { return new Vector2(a.x - b.x, a.y - b.y); }

        public Vector2(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Mesh 
    {
		public Vector3[] normals { set; get; }
		public Vector3[] vertices { set; get; }
		public Vector2[] uvs { set; get; }
		public int[] triangles { set; get; }
    	public Mesh() {}
    }

	public class List<T> 
	{
		public List<T>() 
		{
			throw new NotImplemented();
		}
	}

	public class Dictionary<TKey, TValue> 
	{
		public Dictionary<TKey, TValue>() 
		{
			throw new NotImplemented();
		}
	}

	public class Tree<T> 
	{
		public List<T>() 
		{
			throw new NotImplemented();
		}
	}
}