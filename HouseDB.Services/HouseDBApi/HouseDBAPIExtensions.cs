// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HouseDB.Services.HouseDBApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HouseDBAPI.
    /// </summary>
    public static partial class HouseDBAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceID'>
            /// </param>
            public static Device DeviceGetDeviceGet(this IHouseDBAPI operations, long deviceID)
            {
                return operations.DeviceGetDeviceGetAsync(deviceID).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceID'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Device> DeviceGetDeviceGetAsync(this IHouseDBAPI operations, long deviceID, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeviceGetDeviceGetWithHttpMessagesAsync(deviceID, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Device> DeviceGetAllKwhExportDevicesGet(this IHouseDBAPI operations)
            {
                return operations.DeviceGetAllKwhExportDevicesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Device>> DeviceGetAllKwhExportDevicesGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeviceGetAllKwhExportDevicesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Device> DeviceGetAllDevicesForCachingValuesGet(this IHouseDBAPI operations)
            {
                return operations.DeviceGetAllDevicesForCachingValuesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Device>> DeviceGetAllDevicesForCachingValuesGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeviceGetAllDevicesForCachingValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Device> DeviceGetAllMotionDetectionDevicesGet(this IHouseDBAPI operations)
            {
                return operations.DeviceGetAllMotionDetectionDevicesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Device>> DeviceGetAllMotionDetectionDevicesGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeviceGetAllMotionDetectionDevicesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domoticzP1Consumptions'>
            /// </param>
            public static void ExporterInsertDomoticzP1ConsumptionPost(this IHouseDBAPI operations, IList<DomoticzP1Consumption> domoticzP1Consumptions = default(IList<DomoticzP1Consumption>))
            {
                operations.ExporterInsertDomoticzP1ConsumptionPostAsync(domoticzP1Consumptions).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domoticzP1Consumptions'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExporterInsertDomoticzP1ConsumptionPostAsync(this IHouseDBAPI operations, IList<DomoticzP1Consumption> domoticzP1Consumptions = default(IList<DomoticzP1Consumption>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExporterInsertDomoticzP1ConsumptionPostWithHttpMessagesAsync(domoticzP1Consumptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientModel'>
            /// </param>
            public static void ExporterInsertDomoticzKwhValuesPost(this IHouseDBAPI operations, DomoticzKwhValuesClientModel clientModel = default(DomoticzKwhValuesClientModel))
            {
                operations.ExporterInsertDomoticzKwhValuesPostAsync(clientModel).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientModel'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExporterInsertDomoticzKwhValuesPostAsync(this IHouseDBAPI operations, DomoticzKwhValuesClientModel clientModel = default(DomoticzKwhValuesClientModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExporterInsertDomoticzKwhValuesPostWithHttpMessagesAsync(clientModel, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientModel'>
            /// </param>
            public static void ExporterInsertValuesForCachingPost(this IHouseDBAPI operations, DomoticzValuesForCachingClientModel clientModel = default(DomoticzValuesForCachingClientModel))
            {
                operations.ExporterInsertValuesForCachingPostAsync(clientModel).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientModel'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExporterInsertValuesForCachingPostAsync(this IHouseDBAPI operations, DomoticzValuesForCachingClientModel clientModel = default(DomoticzValuesForCachingClientModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExporterInsertValuesForCachingPostWithHttpMessagesAsync(clientModel, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientModel'>
            /// </param>
            public static void ExporterInsertMotionDetectionValuesPost(this IHouseDBAPI operations, DomoticzMotionDetectionClientModel clientModel = default(DomoticzMotionDetectionClientModel))
            {
                operations.ExporterInsertMotionDetectionValuesPostAsync(clientModel).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientModel'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExporterInsertMotionDetectionValuesPostAsync(this IHouseDBAPI operations, DomoticzMotionDetectionClientModel clientModel = default(DomoticzMotionDetectionClientModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExporterInsertMotionDetectionValuesPostWithHttpMessagesAsync(clientModel, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domoticzPostDatabaseFile'>
            /// </param>
            public static void ExporterUploadDatabasePost(this IHouseDBAPI operations, DomoticzPostDatabaseFile domoticzPostDatabaseFile = default(DomoticzPostDatabaseFile))
            {
                operations.ExporterUploadDatabasePostAsync(domoticzPostDatabaseFile).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domoticzPostDatabaseFile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExporterUploadDatabasePostAsync(this IHouseDBAPI operations, DomoticzPostDatabaseFile domoticzPostDatabaseFile = default(DomoticzPostDatabaseFile), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExporterUploadDatabasePostWithHttpMessagesAsync(domoticzPostDatabaseFile, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void HeaterGetAllGet(this IHouseDBAPI operations)
            {
                operations.HeaterGetAllGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task HeaterGetAllGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.HeaterGetAllGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void HeaterGetClientModelGet(this IHouseDBAPI operations)
            {
                operations.HeaterGetClientModelGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task HeaterGetClientModelGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.HeaterGetClientModelGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static VeraSettings SettingsGetVeraSettingsGet(this IHouseDBAPI operations)
            {
                return operations.SettingsGetVeraSettingsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VeraSettings> SettingsGetVeraSettingsGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SettingsGetVeraSettingsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DataMineSettings SettingsGetDataMineSettingsGet(this IHouseDBAPI operations)
            {
                return operations.SettingsGetDataMineSettingsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataMineSettings> SettingsGetDataMineSettingsGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SettingsGetDataMineSettingsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static RaspicamSettings SettingsGetRaspicamSettingsGet(this IHouseDBAPI operations)
            {
                return operations.SettingsGetRaspicamSettingsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RaspicamSettings> SettingsGetRaspicamSettingsGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SettingsGetRaspicamSettingsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DomoticzSettings SettingsGetDomoticzSettingsGet(this IHouseDBAPI operations)
            {
                return operations.SettingsGetDomoticzSettingsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomoticzSettings> SettingsGetDomoticzSettingsGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SettingsGetDomoticzSettingsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SevenSegmentClientModel SevenSegmentGetClientModelGet(this IHouseDBAPI operations)
            {
                return operations.SevenSegmentGetClientModelGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SevenSegmentClientModel> SevenSegmentGetClientModelGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SevenSegmentGetClientModelGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='postGetKwhYearUsage'>
            /// </param>
            public static KwhYearUsageClientModel StatisticsGetKwhYearUsagePost(this IHouseDBAPI operations, PostGetKwhYearUsage postGetKwhYearUsage = default(PostGetKwhYearUsage))
            {
                return operations.StatisticsGetKwhYearUsagePostAsync(postGetKwhYearUsage).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='postGetKwhYearUsage'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KwhYearUsageClientModel> StatisticsGetKwhYearUsagePostAsync(this IHouseDBAPI operations, PostGetKwhYearUsage postGetKwhYearUsage = default(PostGetKwhYearUsage), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatisticsGetKwhYearUsagePostWithHttpMessagesAsync(postGetKwhYearUsage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LastMotionDetectionsClientModel StatisticsGetLastMotionDetectionsGet(this IHouseDBAPI operations)
            {
                return operations.StatisticsGetLastMotionDetectionsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LastMotionDetectionsClientModel> StatisticsGetLastMotionDetectionsGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatisticsGetLastMotionDetectionsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<CurrentUsage> StatisticsGetCurrentUsagesGet(this IHouseDBAPI operations)
            {
                return operations.StatisticsGetCurrentUsagesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CurrentUsage>> StatisticsGetCurrentUsagesGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatisticsGetCurrentUsagesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<DeviceOverview> StatisticsWeekDeviceOverviewGet(this IHouseDBAPI operations)
            {
                return operations.StatisticsWeekDeviceOverviewGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DeviceOverview>> StatisticsWeekDeviceOverviewGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatisticsWeekDeviceOverviewGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<DayOverview> StatisticsWeekDayOverviewGet(this IHouseDBAPI operations)
            {
                return operations.StatisticsWeekDayOverviewGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DayOverview>> StatisticsWeekDayOverviewGetAsync(this IHouseDBAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatisticsWeekDayOverviewGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='year'>
            /// </param>
            public static IList<MonthOverview> StatisticsYearMonthOverviewGet(this IHouseDBAPI operations, int year)
            {
                return operations.StatisticsYearMonthOverviewGetAsync(year).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MonthOverview>> StatisticsYearMonthOverviewGetAsync(this IHouseDBAPI operations, int year, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatisticsYearMonthOverviewGetWithHttpMessagesAsync(year, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
