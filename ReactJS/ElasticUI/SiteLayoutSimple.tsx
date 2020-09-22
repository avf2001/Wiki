import React, { useState } from "react";

import {
  EuiCollapsibleNav,
  EuiCollapsibleNavGroup,
  EuiFlexItem,
  EuiHeader,
  EuiHeaderSectionItemButton,
  EuiIcon,
  EuiListGroupItem,
  EuiPage,
} from "@elastic/eui";

const SiteLayoutSimple = () => {  
  const [navIsOpen, setNavIsOpen] = useState(false);
  const [navIsDocked, setNavIsDocked] = useState(false);  

  const toggleIsOpen = () => setNavIsOpen(!navIsOpen);
  const toggleIsDocked = () => setNavIsDocked(!navIsDocked);

  const collapsibleNav = (
    <EuiCollapsibleNav
      aria-label="Main navigation"
      isOpen={navIsOpen}
      isDocked={navIsDocked}
      style={{ top: "98px", height: "calc(100% - 98px)" }}
      button={
        <EuiHeaderSectionItemButton
          aria-label="Toggle main navigation"
          onClick={toggleIsOpen}
        >
          <EuiIcon type={"menu"} size="m" aria-hidden="true" />
        </EuiHeaderSectionItemButton>
      }
      onClose={() => setNavIsOpen(false)}
    >
      <EuiFlexItem className="eui-yScroll"></EuiFlexItem>
      <EuiFlexItem grow={false}>
        <EuiCollapsibleNavGroup>
          <EuiListGroupItem
            color="subdued"
            label={`${navIsDocked ? "Undock" : "Dock"} navigation`}
            onClick={toggleIsDocked}
            iconType={navIsDocked ? "lock" : "lockOpen"}
          />
        </EuiCollapsibleNavGroup>
      </EuiFlexItem>
    </EuiCollapsibleNav>
  );

  return (
    <>
      <EuiHeader theme="dark" position="fixed" sections={[]} />
      <EuiHeader
        position="fixed"
        sections={[{ items: [collapsibleNav], borders: "right" }]}
      />

      <EuiPage className="guideFullScreenOverlay" />
    </>
  );
};

export default SiteLayoutSimple;
