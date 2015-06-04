require "common/define"
require "common/functions"

PromptPanel = {};
local this = PromptPanel;

local panel;
local prompt;
local transform;
local gameObject;

--启动事件--
function PromptPanel.Start()
	panel = this.transform:GetComponent('UIPanel');
	prompt = this.transform:GetComponent('BaseLua');
	warn("Start--->>gameObject:>>"..this.gameObject.name.." transform:>"..this.transform.name);

	this.InitPanel();	--初始化面板--
	prompt:AddClick('Open', this.OnClick);
end

--初始化面板--
function PromptPanel.InitPanel()
	panel.depth = 1;	--设置纵深--
	local parent = this.transform:Find('ScrollView/Grid');
	local itemPrefab = prompt:GetGameObject('PromptItem');
	for i = 1, 100 do
		local go = newobject(itemPrefab);
		go.name = tostring(i);
		go.transform.parent = parent;
		go.transform.localScale = Vector3.one;
		go.transform.localPosition = Vector3.zero;

		local goo = go.transform:FindChild('Label');
		goo:GetComponent('UILabel').text = i;
	end
	local grid = parent:GetComponent('UIGrid');
	grid:Reposition();
	grid.repositionNow = true;
	parent:GetComponent('UIWrapGrid'):InitGrid();
end

--单击事件--
function PromptPanel.OnClick(go)
    local buffer = ByteBuffer.New();
    buffer:WriteShort(Login);
    buffer:WriteString("ffff我的ffffQ靈uuu");
    buffer:WriteInt(200);
    ioo.networkManager:SendMessage(buffer);
	warn("OnClick---->>>"..go.name);
end