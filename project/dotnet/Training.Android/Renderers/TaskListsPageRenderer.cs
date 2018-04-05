//
// TaskListsPageRenderer.cs
//
// Author:
// 	Jim Borden  <jim.borden@couchbase.com>
//
// Copyright (c) 2016 Couchbase, Inc All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using System;

using Android.App;
using Android.Content.PM;
using Android.Hardware;
using Android.OS;
using Android.Views;
using Training.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(Training.TaskListsPage), typeof(Training.Android.TaskListsPageRenderer))]

namespace Training.Android
{
    public sealed class TaskListsPageRenderer : ShakeReactPageRenderer
    {
        protected override void HandleShake()
        {
            var page = this.Element as TaskListsPage;
            var vm = page.BindingContext as TaskListsViewModel;
            vm.TestConflict();
        }
    }
}
