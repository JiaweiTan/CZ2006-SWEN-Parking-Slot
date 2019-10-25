(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-149b41f1"],{"09ee":function(e,t,s){"use strict";s.r(t);var a=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("v-content",[s("v-container",{attrs:{fluid:""}},[s("v-layout",{attrs:{column:""}},[s("v-card",[s("v-alert",{attrs:{value:e.notifyStatus,dismissible:"",type:"success"}},[e._v(e._s(e.notifyText))]),s("v-card-text",{directives:[{name:"show",rawName:"v-show",value:e.updateAccount,expression:"updateAccount"}]},[s("v-flex",{staticClass:"mb-6"},[s("v-avatar",{staticClass:"mr-4",attrs:{size:"96"}},[s("img",{attrs:{src:"https://randomuser.me/api/portraits/men/81.jpg",alt:"Avatar"}})])],1),s("v-text-field",{attrs:{name:"username",label:"Username"},model:{value:e.userProfile.username,callback:function(t){e.$set(e.userProfile,"username",t)},expression:"userProfile.username"}}),s("v-text-field",{attrs:{name:"firstName",label:"First Name"},model:{value:e.userProfile.firstName,callback:function(t){e.$set(e.userProfile,"firstName",t)},expression:"userProfile.firstName"}}),s("v-text-field",{attrs:{name:"lastName",label:"Last Name"},model:{value:e.userProfile.lastName,callback:function(t){e.$set(e.userProfile,"lastName",t)},expression:"userProfile.lastName"}}),s("v-text-field",{attrs:{name:"email",label:"Email Address"},model:{value:e.userProfile.Email,callback:function(t){e.$set(e.userProfile,"Email",t)},expression:"userProfile.Email"}}),s("v-text-field",{attrs:{name:"contact",label:"Contact Number"},model:{value:e.userProfile.Contact,callback:function(t){e.$set(e.userProfile,"Contact",t)},expression:"userProfile.Contact"}})],1),s("v-card-text",{directives:[{name:"show",rawName:"v-show",value:!e.updateAccount,expression:"!updateAccount"}]},[s("v-text-field",{attrs:{name:"password",label:"Current password",type:"password"},model:{value:e.userPassword.currentpassword,callback:function(t){e.$set(e.userPassword,"currentpassword",t)},expression:"userPassword.currentpassword"}}),s("v-text-field",{attrs:{name:"password",label:"New password",type:"password"},model:{value:e.userPassword.newpassword,callback:function(t){e.$set(e.userPassword,"newpassword",t)},expression:"userPassword.newpassword"}}),s("v-text-field",{attrs:{name:"cfmpassword",label:"Confirm new password",type:"password"},model:{value:e.userPassword.cfmnewpassword,callback:function(t){e.$set(e.userPassword,"cfmnewpassword",t)},expression:"userPassword.cfmnewpassword"}})],1),s("v-card-actions",{directives:[{name:"show",rawName:"v-show",value:e.updateAccount,expression:"updateAccount"}]},[s("v-btn",{attrs:{color:"primary"},on:{click:e.updateProfile}},[s("v-icon",{attrs:{left:"",dark:""}},[e._v("mdi-check")]),e._v("Save Changes\n          ")],1),s("v-btn",{attrs:{color:"warning"},on:{click:e.reset}},[s("v-icon",{attrs:{left:"",dark:""}},[e._v("mdi-lock-reset")]),e._v("Change Password\n          ")],1)],1),s("v-card-actions",{directives:[{name:"show",rawName:"v-show",value:!e.updateAccount,expression:"!updateAccount"}]},[s("v-btn",{attrs:{color:"primary"},on:{click:e.updatePassword}},[s("v-icon",{attrs:{left:"",dark:""}},[e._v("mdi-check")]),e._v("Update Password\n          ")],1),s("v-btn",{attrs:{color:"warning"},on:{click:e.reset}},[s("v-icon",{attrs:{left:"",dark:""}},[e._v("mdi-arrow-left")]),e._v("Back\n          ")],1)],1)],1)],1)],1)],1)},r=[],o={data(){return{userProfile:{username:this.$store.getters.USERNAME,firstName:this.$store.getters.FIRSTNAME,lastName:this.$store.getters.LASTNAME,Email:this.$store.getters.EMAIL,Contact:this.$store.getters.PHONENO},userPassword:{currentpassword:"",newpassword:"",cfmnewpassword:""},updateAccount:!0,notifyStatus:!1,notifyText:""}},methods:{updateProfile(){this.notifyStatus=!0,this.notifyText="Profile have been successfully updated!"},updatePassword(){this.notifyStatus=!0,this.notifyText="Password have been successfully updated!",this.updateAccount=!0},reset(){this.updateAccount=!this.updateAccount,this.notifyStatus=!1}}},n=o,i=s("2877"),l=s("6544"),c=s.n(l),d=s("0798"),u=s("8212"),p=s("8336"),f=s("b0af"),m=s("99d9"),v=s("a523"),w=s("a75b"),h=s("0e8f"),x=s("132d"),b=s("a722"),P=s("8654"),y=Object(i["a"])(n,a,r,!1,null,null,null);t["default"]=y.exports;c()(y,{VAlert:d["a"],VAvatar:u["a"],VBtn:p["a"],VCard:f["a"],VCardActions:m["a"],VCardText:m["b"],VContainer:v["a"],VContent:w["a"],VFlex:h["a"],VIcon:x["a"],VLayout:b["a"],VTextField:P["a"]})},a75b:function(e,t,s){"use strict";s("daaf");var a=s("d10f");t["a"]=a["a"].extend({name:"v-content",props:{tag:{type:String,default:"main"}},computed:{styles(){const{bar:e,top:t,right:s,footer:a,insetFooter:r,bottom:o,left:n}=this.$vuetify.application;return{paddingTop:`${t+e}px`,paddingRight:`${s}px`,paddingBottom:`${a+r+o}px`,paddingLeft:`${n}px`}}},render(e){const t={staticClass:"v-content",style:this.styles,ref:"content"};return e(this.tag,t,[e("div",{staticClass:"v-content__wrap"},this.$slots.default)])}})},daaf:function(e,t,s){}}]);
//# sourceMappingURL=chunk-149b41f1.f9dc7d1c.js.map