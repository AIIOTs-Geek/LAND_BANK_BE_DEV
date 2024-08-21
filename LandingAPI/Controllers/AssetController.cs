﻿using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace LandingAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssetController : BaseController
    {
        private readonly IAssetService _assetService;
        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetStatus(string statusType)
        {
            return Response(await _assetService.GetStatus(statusType));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssets()
        {
            return Response(await _assetService.GetAssets());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            return Response(await _assetService.GetCities());
        }
        [HttpGet]
        public async Task<IActionResult> GetDistrictsByCityId(int cityId)
        {
            return Response(await _assetService.GetDistrictsByCityId(cityId));
        }
        [HttpGet]
        public async Task<IActionResult> GetAssets(string? search, string? cityId, int? districtId, int? assetId, int? userId, int? landUseId, int? wltId, int? businessPlan)
        {
            return Response(await _assetService.GetAssets(search,cityId,districtId,assetId,userId,landUseId,wltId,businessPlan));
        }
    }
}
