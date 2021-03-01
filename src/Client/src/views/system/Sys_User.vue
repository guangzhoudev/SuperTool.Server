<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/Sys_User.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/system/Sys_User.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'User_Id',
                    footer: "Foots",
                    cnName: '用户管理',
                    name: 'Sys_User',
                    url: "/Sys_User/",
                    sortName: "User_Id"
                },
                extend: extend,
                editFormFields: {"UserName":"","Role_Id":"","UserTrueName":"","Gender":"","IsRegregisterPhone":"","Enable":"","HeadImageUrl":"","CreateDate":"","Creator":"","Remark":""},
                editFormOptions: [[{"title":"帐号","required":true,"field":"UserName","disabled":true},
                               {"dataKey":"roles","data":[],"title":"角色","required":true,"field":"Role_Id","type":"select"},
                               {"title":"真实姓名","required":true,"field":"UserTrueName","type":"text"}],
                              [{"dataKey":"gender","data":[],"title":"性别","field":"Gender","type":"select"},
                               {"dataKey":"isphone","data":[],"title":"手机用户","required":true,"field":"IsRegregisterPhone","type":"select"},
                               {"dataKey":"enable","data":[],"title":"是否可用","required":true,"field":"Enable","type":"select"}],
                              [{"title":"头像","field":"HeadImageUrl","type":"img"},
                               {"title":"注册时间","field":"CreateDate","disabled":true},
                               {"title":"创建人","field":"Creator","disabled":true}],
                              [{"title":"备注","field":"Remark","colSize":12,"type":"textarea"}]],
                searchFormFields: {"UserName":"","Gender":"","DeptName":"","Role_Id":"","Token":"","AppType":[],"UserTrueName":"","CreateDate":"","IsRegregisterPhone":"","PhoneNo":"","Enable":"","LastLoginDate":"","Address":"","Email":""},
                searchFormOptions: [[{"title":"帐号","field":"UserName"},{"dataKey":"gender","data":[],"title":"性别","field":"Gender","type":"select"},{"title":"真实姓名","field":"UserTrueName"}],[{"title":"部门","field":"DeptName"},{"dataKey":"roles","data":[],"title":"角色","field":"Role_Id","type":"select"},{"title":"Token","field":"Token"}],[{"dataKey":"ut","data":[],"title":"登陆设备类型","field":"AppType","type":"selectList"},{"dataKey":"isphone","data":[],"title":"手机用户","field":"IsRegregisterPhone","type":"select"},{"title":"手机号","field":"PhoneNo"}],[{"dataKey":"enable","data":[],"title":"是否可用","field":"Enable","type":"select"},{"title":"地址","field":"Address"},{"title":"Email","field":"Email"}],[{"title":"注册时间","field":"CreateDate","type":"datetime"},{"title":"最后登陆时间","field":"LastLoginDate","type":"datetime"}]],
                columns: [{field:'UserName',title:'帐号',type:'string',link:true,width:120,readonly:true,require:true,align:'left',sortable:true},
                       {field:'User_Id',title:'User_Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Gender',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:100,align:'left'},
                       {field:'HeadImageUrl',title:'头像',type:'img',width:150,align:'left'},
                       {field:'Dept_Id',title:'Dept_Id',type:'int',width:90,hidden:true,align:'left'},
                       {field:'DeptName',title:'部门',type:'string',width:150,hidden:true,align:'left'},
                       {field:'Role_Id',title:'角色',type:'int',bind:{ key:'roles',data:[]},width:150,require:true,align:'left'},
                       {field:'RoleName',title:'RoleName',type:'string',width:90,hidden:true,require:true,align:'left'},
                       {field:'Token',title:'Token',type:'string',width:180,hidden:true,align:'left'},
                       {field:'AppType',title:'登陆设备类型',type:'int',bind:{ key:'ut',data:[]},width:150,hidden:true,align:'left'},
                       {field:'UserTrueName',title:'真实姓名',type:'string',width:150,require:true,align:'left'},
                       {field:'CreateDate',title:'注册时间',type:'datetime',width:150,readonly:true,align:'left',sortable:true},
                       {field:'IsRegregisterPhone',title:'手机用户',type:'int',bind:{ key:'isphone',data:[]},width:120,hidden:true,require:true,align:'left'},
                       {field:'PhoneNo',title:'手机号',type:'string',width:150,hidden:true,align:'left'},
                       {field:'Tel',title:'Tel',type:'string',width:90,hidden:true,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,readonly:true,align:'left'},
                       {field:'Enable',title:'是否可用',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,hidden:true,readonly:true,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,readonly:true,align:'left',sortable:true},
                       {field:'AuditStatus',title:'审核状态',type:'int',bind:{ key:'audit',data:[]},width:90,hidden:true,align:'left'},
                       {field:'Auditor',title:'审核人',type:'string',width:90,hidden:true,align:'left'},
                       {field:'AuditDate',title:'审核时间',type:'datetime',width:150,hidden:true,align:'left',sortable:true},
                       {field:'LastLoginDate',title:'最后登陆时间',type:'datetime',width:150,hidden:true,align:'left',sortable:true},
                       {field:'LastModifyPwdDate',title:'最后密码修改时间',type:'datetime',width:150,hidden:true,align:'left',sortable:true},
                       {field:'Address',title:'地址',type:'string',width:190,hidden:true,align:'left'},
                       {field:'Mobile',title:'电话',type:'string',width:140,hidden:true,align:'left'},
                       {field:'Email',title:'Email',type:'string',width:140,hidden:true,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:180,hidden:true,align:'left'},
                       {field:'OrderNo',title:'排序号',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Stores',title:'店铺清单',type:'string',width:220,hidden:true,align:'left'}],
                detail: {
                    cnName:"店铺管理",
                    columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CustomerName',title:'公司名称',type:'string',width:120,edit:{type:''},align:'left',sortable:true},
                       {field:'ShopId',title:'店铺ID',type:'string',width:120,edit:{type:''},align:'left'},
                       {field:'ShopName',title:'店铺名称',type:'string',width:120,edit:{type:''},align:'left'},
                       {field:'Contact',title:'联系人',type:'string',width:90,edit:{type:''},align:'left'},
                       {field:'Type',title:'店铺类型',type:'string',width:90,edit:{type:''},align:'left'},
                       {field:'BindTime',title:'绑定时间',type:'datetime',width:90,edit:{type:'datetime'},align:'left',sortable:true},
                       {field:'Address',title:'店铺地址',type:'string',width:220,edit:{type:''},align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'编辑时间',type:'datetime',width:90,hidden:true,align:'left',sortable:true},
                       {field:'Modifier',title:'编辑人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyID',title:'编辑人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'User_Id',title:'用户ID',type:'int',width:80,hidden:true,align:'left'}],
                    sortName: "Id",
                    key:"Id"
                }
            };
        }
    };
    export default vueParam;
</script>
