let viewgird = [
   {
        path: '/Sys_Log',
        name: 'sys_Log',
        component: () => import('@/views/system/Sys_Log.vue')
    }
    ,{
        path: '/Sys_User',
        name: 'Sys_User',
        component: () => import('@/views/system/Sys_User.vue')
    }    ,{
        path: '/Sys_Dictionary',
        name: 'Sys_Dictionary',
        component: () => import('@/views/system/Sys_Dictionary.vue')
    }    ,{
        path: '/Sys_Role',
        name: 'Sys_Role',
        component: () => import('@/views/system/Sys_Role.vue')
    }
    ,{
        path: '/Sys_DictionaryList',
        name: 'Sys_DictionaryList',
        component: () => import('@/views/system/Sys_DictionaryList.vue')
    }
    ,{
        path: '/SellOrder',
        name: 'SellOrder',
        component: () => import('@/views/order/SellOrder.vue')
    }    ,{
      path: '/vSellOrderImg',
      name: 'vSellOrderImg',
      component: () => import('@/views/order/vSellOrderImg.vue')
      }     ,{
        path: '/App_Appointment',
        name: 'App_Appointment',
        component: () => import('@/views/order/App_Appointment.vue')
    }    ,{
        path: '/App_TransactionAvgPrice',
        name: 'App_TransactionAvgPrice',
        component: () => import('@/views/appmanager/App_TransactionAvgPrice.vue')
    }    ,{
        path: '/App_Expert',
        name: 'App_Expert',
        component: () => import('@/views/appmanager/App_Expert.vue')
    }    ,{
        path: '/App_Transaction',
        name: 'App_Transaction',
        component: () => import('@/views/appmanager/App_Transaction.vue')
    }    ,{
        path: '/App_ReportPrice',
        name: 'App_ReportPrice',
        component: () => import('@/views/appmanager/App_ReportPrice.vue')
    }    ,{
        path: '/App_News',
        name: 'App_News',
        component: () => import('@/views/appmanager/App_News.vue')
    }    ,{
        path: '/App_NewsEditor',
        name: 'App_NewsEditor',
        component: () => import('@/views/appmanager/App_NewsEditor.vue')
    }    ,{
        path: '/UpdateLogs',
        name: 'UpdateLogs',
        component: () => import('@/views/order/UpdateLogs.vue')
    }    ,{
        path: '/WorkOrder',
        name: 'WorkOrder',
        component: () => import('@/views/order/WorkOrder.vue')
    }    ,{
        path: '/PayLogs',
        name: 'PayLogs',
        component: () => import('@/views/order/PayLogs.vue')
    }    ,{
        path: '/Ad',
        name: 'Ad',
        component: () => import('@/views/order/Ad.vue')
    }    ,{
        path: '/Carousel',
        name: 'Carousel',
        component: () => import('@/views/order/Carousel.vue')
    }    ,{
        path: '/SensitiveWordFilter',
        name: 'SensitiveWordFilter',
        component: () => import('@/views/order/SensitiveWordFilter.vue')
    }    ,{
        path: '/UsageRecord',
        name: 'UsageRecord',
        component: () => import('@/views/order/UsageRecord.vue')
    }    ,{
        path: '/AppLog',
        name: 'AppLog',
        component: () => import('@/views/order/AppLog.vue')
    }    ,{
        path: '/TaskInfo',
        name: 'TaskInfo',
        component: () => import('@/views/order/TaskInfo.vue')
    }    ,{
        path: '/TaskRecord',
        name: 'TaskRecord',
        component: () => import('@/views/order/TaskRecord.vue')
    }]

export default viewgird
