﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DesktopAppTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DesktopAppTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("c770f77b-b046-4126-ba9a-6d4f1f85890d")]
    public partial class DesktopAppTestRepository : RepoGenBaseFolder
    {
        static DesktopAppTestRepository instance = new DesktopAppTestRepository();
        DesktopAppTestRepositoryFolders.UntitledPaintAppFolder _untitledpaint;

        /// <summary>
        /// Gets the singleton class instance representing the DesktopAppTestRepository element repository.
        /// </summary>
        [RepositoryFolder("c770f77b-b046-4126-ba9a-6d4f1f85890d")]
        public static DesktopAppTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DesktopAppTestRepository() 
            : base("DesktopAppTestRepository", "/", null, 0, false, "c770f77b-b046-4126-ba9a-6d4f1f85890d", ".\\RepositoryImages\\DesktopAppTestRepositoryc770f77b.rximgres")
        {
            _untitledpaint = new DesktopAppTestRepositoryFolders.UntitledPaintAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c770f77b-b046-4126-ba9a-6d4f1f85890d")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The UntitledPaint folder.
        /// </summary>
        [RepositoryFolder("5c3c9e0a-7e95-471e-861f-1e244464b90d")]
        public virtual DesktopAppTestRepositoryFolders.UntitledPaintAppFolder UntitledPaint
        {
            get { return _untitledpaint; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class DesktopAppTestRepositoryFolders
    {
        /// <summary>
        /// The UntitledPaintAppFolder folder.
        /// </summary>
        [RepositoryFolder("5c3c9e0a-7e95-471e-861f-1e244464b90d")]
        public partial class UntitledPaintAppFolder : RepoGenBaseFolder
        {
            Afx00007FF6543500008InfoClass _afx00007ff6543500008Info;
            RepoItemInfo _triangleInfo;
            RepoItemInfo _copy_of_triangleInfo;

            /// <summary>
            /// Creates a new UntitledPaint  folder.
            /// </summary>
            public UntitledPaintAppFolder(RepoGenBaseFolder parentFolder) :
                    base("UntitledPaint", "/form[@title='Untitled - Paint']", parentFolder, 30000, null, true, "5c3c9e0a-7e95-471e-861f-1e244464b90d", "")
            {
                _afx00007ff6543500008Info = new Afx00007FF6543500008InfoClass(this);
                _triangleInfo = new RepoItemInfo(this, "Triangle", "container[@name='UIRibbonDockTop']/container[@name='Ribbon']//container[@classname='NetUIHWND']/container[@name='Lower Ribbon']//toolbar[@name='Shapes']/?/?/list[@name='Shapes']/?/?/listitem[@name='Triangle']", 30000, null, "766cc155-3712-4c42-acb3-49f6d6ac7880");
                _copy_of_triangleInfo = new RepoItemInfo(this, "Copy_of_Triangle", "form[@title='Untitled - Paint']/container[@name='UIRibbonDockTop']/container[@name='Ribbon']//container[@classname='NetUIHWND']/container[@name='Lower Ribbon']//toolbar[@name='Shapes']/?/?/list[@name='Shapes']/?/?/listitem[@name='Triangle']", 30000, null, "45b44ce4-35cf-4950-acbb-a33070c81bf0");
            }

            /// <summary>
            /// The Afx00007FF6543500008InfoClass folder.
            /// </summary>
            [RepositoryItemInfo("8bb6ad15-ae09-491c-bc79-7f6b924a1525")]
            public class Afx00007FF6543500008InfoClass : RepoItemInfo
            {
                /// <summary>
                /// Afx00007FF6543500008InfoClass class constructor.
                /// </summary>
                public Afx00007FF6543500008InfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "Afx00007FF6543500008", "element[@controlid='59648']", 30000, null, "8bb6ad15-ae09-491c-bc79-7f6b924a1525")
                { }

                /// <summary>
                /// Gets the picToCompare1 item image.
                /// </summary>
                /// <returns>The picToCompare1 image.</returns>
                [RepositoryImage("595a39c0-0781-4859-aac9-a9491f01bedd")]
                public CompressedImage GetpicToCompare1()
                {
                    return GetImage("595a39c0-0781-4859-aac9-a9491f01bedd");
                }

                /// <summary>
                /// Gets the picToCompare1 item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("595a39c0-0781-4859-aac9-a9491f01bedd")]
                public CompressedImage GetpicToCompare1(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("595a39c0-0781-4859-aac9-a9491f01bedd", cropRect);
                }

                /// <summary>
                /// Gets the Screenshot1 item image.
                /// </summary>
                /// <returns>The Screenshot1 image.</returns>
                [RepositoryImage("f6130ae5-2f01-4d2c-8c14-a0af0d752ed2")]
                public CompressedImage GetScreenshot1()
                {
                    return GetImage("f6130ae5-2f01-4d2c-8c14-a0af0d752ed2");
                }

                /// <summary>
                /// Gets the Screenshot1 item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("f6130ae5-2f01-4d2c-8c14-a0af0d752ed2")]
                public CompressedImage GetScreenshot1(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("f6130ae5-2f01-4d2c-8c14-a0af0d752ed2", cropRect);
                }
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5c3c9e0a-7e95-471e-861f-1e244464b90d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5c3c9e0a-7e95-471e-861f-1e244464b90d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Afx00007FF6543500008 item.
            /// </summary>
            [RepositoryItem("8bb6ad15-ae09-491c-bc79-7f6b924a1525")]
            public virtual Ranorex.Unknown Afx00007FF6543500008
            {
                get
                {
                    return _afx00007ff6543500008Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Afx00007FF6543500008 item info.
            /// </summary>
            [RepositoryItemInfo("8bb6ad15-ae09-491c-bc79-7f6b924a1525")]
            public virtual Afx00007FF6543500008InfoClass Afx00007FF6543500008Info
            {
                get
                {
                    return _afx00007ff6543500008Info;
                }
            }

            /// <summary>
            /// The Triangle item.
            /// </summary>
            [RepositoryItem("766cc155-3712-4c42-acb3-49f6d6ac7880")]
            public virtual Ranorex.ListItem Triangle
            {
                get
                {
                    return _triangleInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Triangle item info.
            /// </summary>
            [RepositoryItemInfo("766cc155-3712-4c42-acb3-49f6d6ac7880")]
            public virtual RepoItemInfo TriangleInfo
            {
                get
                {
                    return _triangleInfo;
                }
            }

            /// <summary>
            /// The Copy_of_Triangle item.
            /// </summary>
            [RepositoryItem("45b44ce4-35cf-4950-acbb-a33070c81bf0")]
            public virtual Ranorex.ListItem Copy_of_Triangle
            {
                get
                {
                    return _copy_of_triangleInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Copy_of_Triangle item info.
            /// </summary>
            [RepositoryItemInfo("45b44ce4-35cf-4950-acbb-a33070c81bf0")]
            public virtual RepoItemInfo Copy_of_TriangleInfo
            {
                get
                {
                    return _copy_of_triangleInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
