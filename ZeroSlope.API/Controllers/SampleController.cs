﻿using ZeroSlope.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ZeroSlope.Domain.BindingModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace ZeroSlope.Service.Controllers
{
	[Route("api/[controller]"), Authorize]
	public class SampleController
	{
		private readonly SampleService _Service;

		/// <summary>
		/// Initializes a new instance of the <see cref="TestController"/> class.
		/// </summary>
		/// <param name="Service">The service.</param>
		public SampleController(SampleService Service)
		{
			_Service = Service;
		}

		/// <summary>
		/// Lists all Sample Entities.
		/// </summary>
		/// <returns></returns>
		[HttpGet, Route("")]
		public List<SampleEntityBindingModel> List()
		{
			return _Service.List();
		}

		/// <summary>
		/// Reads a single Sample Entity by Id.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		[HttpGet, Route("{id}")]
		public SampleEntityBindingModel Read(int id)
		{
			return _Service.Read(id);
		}

		/// <summary>
		/// Saves the specified binding model.
		/// </summary>
		/// <param name="bindingModel">The binding model.</param>
		/// <returns></returns>
		[HttpPost, HttpPut, Route("")]
		public SampleEntityBindingModel Save(SampleEntityBindingModel bindingModel)
		{
			return _Service.Save(bindingModel);
		}

		/// <summary>
		/// Deletes the specified model by id.
		/// </summary>
		/// <param name="id">The identifier.</param>
		[HttpDelete, Route("{id}")]
		public void Delete(int id)
		{
			_Service.Delete(id);
		}

		/// <summary>
		/// This is a sample error.
		/// </summary>
		/// <returns></returns>
		[HttpGet, Route("SampleError")]
		public object SampleError()
		{
			return _Service.SampleError();
		}

	}
}
