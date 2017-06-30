﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using WebApplication.ExtensionB.Data.Entities;

namespace WebApplication.ExtensionB.Data.Abstractions
{
  public interface IItemRepository : IRepository
  {
    IEnumerable<Item> All();
  }
}